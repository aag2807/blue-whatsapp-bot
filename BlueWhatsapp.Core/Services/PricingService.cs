using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.Services;

public sealed class PricingService : IPricingService
{
    /// <inheritdoc />
    public decimal CalculateVipPrice(CoreHotel hotel, int adults, int children)
    {
        if (hotel.Price == 0) // Free shuttle service
            return 0;

        int totalPeople = adults + children;
        int minimumPeople = GetMinimumPeople(hotel);
        decimal basePrice = GetBasePrice(hotel);
        decimal additionalPrice = GetAdditionalPersonPrice(hotel);

        // If fewer than minimum, pay for minimum
        if (totalPeople < minimumPeople)
        {
            return basePrice * minimumPeople;
        }

        // Base price for minimum people + additional for extra people
        decimal totalPrice = basePrice * minimumPeople;
        if (totalPeople > minimumPeople)
        {
            totalPrice += (totalPeople - minimumPeople) * additionalPrice;
        }

        return totalPrice;
    }

    /// <inheritdoc />
    public bool MeetsMinimumRequirement(CoreHotel hotel, int totalPeople)
    {
        if (hotel.Price == 0) // Free shuttle service
            return true;

        return totalPeople >= GetMinimumPeople(hotel);
    }

    /// <inheritdoc />
    public string GetPricingDescription(CoreHotel hotel, int languageId)
    {
        if (hotel.Price == 0)
        {
            return GetFreeServiceDescription(languageId);
        }

        int minimumPeople = GetMinimumPeople(hotel);
        decimal basePrice = GetBasePrice(hotel);
        decimal additionalPrice = GetAdditionalPersonPrice(hotel);

        // Special handling for Bayahíbe (different pricing structure)
        if (IsBayahibe(hotel))
        {
            return GetBayahibePricingDescription(languageId);
        }

        // Standard VIP pricing description
        return GetStandardVipPricingDescription(hotel.Name, minimumPeople, basePrice, additionalPrice, languageId);
    }

    /// <inheritdoc />
    public int GetMinimumPeople(CoreHotel hotel)
    {
        if (hotel.Price == 0) return 1; // Free service

        // Bayahíbe has different minimum requirements
        if (IsBayahibe(hotel))
        {
            return 13; // Default to smaller bus, user can choose larger
        }

        // Standard VIP minimum is 4 people
        return 4;
    }

    /// <inheritdoc />
    public decimal GetBasePrice(CoreHotel hotel)
    {
        if (hotel.Price == 0) return 0;

        // Route-based pricing from your script
        switch (hotel.RouteId)
        {
            case 4: // Bávaro (RUTA D)
                return 20m; // $20 base
            case 7: // Uvero Alto (RUTA F)
                return 40m; // $40 base
            default:
                return (decimal)hotel.Price; // Fallback to hotel's configured price
        }
    }

    /// <inheritdoc />
    public decimal GetAdditionalPersonPrice(CoreHotel hotel)
    {
        if (hotel.Price == 0) return 0;

        // Bayahíbe special pricing
        if (IsBayahibe(hotel))
        {
            return 15m; // $15 per person
        }

        // Route-based additional pricing
        switch (hotel.RouteId)
        {
            case 4: // Bávaro (RUTA D)
                return 5m; // $5 per additional person
            case 7: // Uvero Alto (RUTA F)
                return 10m; // $10 per additional person
            default:
                return 5m; // Default fallback
        }
    }

    private bool IsBayahibe(CoreHotel hotel)
    {
        // Check if hotel is in Bayahíbe zone (you might want to add a zone enum)
        return hotel.Route?.ToUpper().Contains("BAYAHIBE") == true ||
               hotel.Name.ToUpper().Contains("BAYAHIBE") ||
               hotel.RouteNavigation?.Description?.ToUpper().Contains("BAYAHIBE") == true;
    }

    private string GetFreeServiceDescription(int languageId)
    {
        return languageId switch
        {
            1 => "Servicio de traslado gratuito disponible.",
            2 => "Free shuttle service available.",
            3 => "Service de navette gratuit disponible.",
            4 => "Доступен бесплатный трансфер.",
            5 => "Serviço de traslado gratuito disponível.",
            6 => "免费班车服务可用。",
            _ => GetFreeServiceDescription(1)
        };
    }

    private string GetBayahibePricingDescription(int languageId)
    {
        return languageId switch
        {
            1 => "Para hoteles en Bayahíbe no tenemos servicio gratis por la distancia, pero podemos coordinar nuestro servicio VIP. El costo dependerá de la cantidad de personas:\n\n• Menos de 15 personas: $15 USD por persona (mínimo 13 personas = $195 USD)\n• Más de 15 personas: $15 USD por persona (mínimo 22 personas = $330 USD)",
            2 => "For hotels in Bayahíbe we don't have free service due to distance, but we can coordinate our VIP service. Cost depends on number of people:\n\n• Less than 15 people: $15 USD per person (minimum 13 people = $195 USD)\n• More than 15 people: $15 USD per person (minimum 22 people = $330 USD)",
            3 => "Pour les hôtels à Bayahíbe, nous n'avons pas de service gratuit en raison de la distance, mais nous pouvons coordonner notre service VIP. Le coût dépend du nombre de personnes:\n\n• Moins de 15 personnes: 15 USD$ par personne (minimum 13 personnes = 195 USD$)\n• Plus de 15 personnes: 15 USD$ par personne (minimum 22 personnes = 330 USD$)",
            4 => "Для отелей в Bayahíbe у нас нет бесплатного сервиса из-за расстояния, но мы можем организовать наш VIP-сервис. Стоимость зависит от количества людей:\n\n• Менее 15 человек: $15 USD за человека (минимум 13 человек = $195 USD)\n• Более 15 человек: $15 USD за человека (минимум 22 человека = $330 USD)",
            5 => "Para hotéis em Bayahíbe não temos serviço gratuito devido à distância, mas podemos coordenar nosso serviço VIP. O custo depende do número de pessoas:\n\n• Menos de 15 pessoas: $15 USD por pessoa (mínimo 13 pessoas = $195 USD)\n• Mais de 15 pessoas: $15 USD por pessoa (mínimo 22 pessoas = $330 USD)",
            6 => "对于Bayahíbe的酒店，由于距离原因我们没有免费服务，但我们可以协调我们的VIP服务。费用取决于人数：\n\n• 少于15人：每人15美元（最少13人=195美元）\n• 超过15人：每人15美元（最少22人=330美元）",
            _ => GetBayahibePricingDescription(1)
        };
    }

    private string GetStandardVipPricingDescription(string hotelName, int minimumPeople, decimal basePrice, decimal additionalPrice, int languageId)
    {
        return languageId switch
        {
            1 => $"Para su hotel {hotelName} no tenemos el servicio de traslado gratuito, pero le podemos ofrecer nuestro servicio VIP, con una duración de 2 horas en el Mall. Nuestras reservas VIP tienen un costo general de {basePrice:C} USD por un mínimo de {minimumPeople} personas. En caso de que vengan menos de {minimumPeople}, pagan el total de {minimumPeople} como monto mínimo. A partir de {minimumPeople} personas se cobrará {additionalPrice:C} USD por cada persona adicional que se agregue. Esto les cubre ida y vuelta.",
            2 => $"For your hotel {hotelName} we don't have free shuttle service, but we can offer you our VIP service, with a 2-hour duration at the Mall. Our VIP reservations have a general cost of {basePrice:C} USD for a minimum of {minimumPeople} people. In case fewer than {minimumPeople} come, they pay the total of {minimumPeople} as the minimum amount. From {minimumPeople} people onwards, {additionalPrice:C} USD will be charged for each additional person added. This covers round trip.",
            3 => $"Pour votre hôtel {hotelName} nous n'avons pas de service de navette gratuit, mais nous pouvons vous offrir notre service VIP, avec une durée de 2 heures au Mall. Nos réservations VIP ont un coût général de {basePrice:C} USD pour un minimum de {minimumPeople} personnes. Au cas où moins de {minimumPeople} viennent, ils paient le total de {minimumPeople} comme montant minimum. À partir de {minimumPeople} personnes, {additionalPrice:C} USD seront facturés pour chaque personne supplémentaire ajoutée. Cela couvre l'aller-retour.",
            4 => $"Для вашего отеля {hotelName} у нас нет бесплатного трансфера, но мы можем предложить вам наш VIP-сервис продолжительностью 2 часа в торговом центре. Наши VIP-бронирования стоят {basePrice:C} долларов США минимум для {minimumPeople} человек. Если приедет меньше {minimumPeople} человек, они платят общую сумму за {minimumPeople} человека как минимальную сумму. Начиная с {minimumPeople} человек, за каждого дополнительного человека взимается {additionalPrice:C} долларов США. Это покрывает поездку туда и обратно.",
            5 => $"Para seu hotel {hotelName} não temos serviço de traslado gratuito, mas podemos oferecer nosso serviço VIP, com duração de 2 horas no Mall. Nossas reservas VIP têm um custo geral de {basePrice:C} USD por um mínimo de {minimumPeople} pessoas. Caso venham menos de {minimumPeople}, pagam o total de {minimumPeople} como valor mínimo. A partir de {minimumPeople} pessoas será cobrado {additionalPrice:C} USD por cada pessoa adicional que se agregue. Isso cobre ida e volta.",
            6 => $"对于您的酒店{hotelName}，我们没有免费班车服务，但我们可以为您提供VIP服务，在购物中心停留2小时。我们的VIP预订一般费用为{basePrice:C}美元，最少{minimumPeople}人。如果少于{minimumPeople}人，按{minimumPeople}人的总费用作为最低金额付费。从{minimumPeople}人开始，每增加一人收费{additionalPrice:C}美元。这包括往返费用。",
            _ => GetStandardVipPricingDescription(hotelName, minimumPeople, basePrice, additionalPrice, 1)
        };
    }
}