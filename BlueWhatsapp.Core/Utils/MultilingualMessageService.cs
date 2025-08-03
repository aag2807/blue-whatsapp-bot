using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using System.Text;

namespace BlueWhatsapp.Core.Utils;

/// <summary>
/// Static service that provides multilingual message templates for the conversation flow.
/// Supports all languages defined in the language selection prompt.
/// </summary>
public static class MultilingualMessageService
{
    /// <summary>
    /// Gets the welcome message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID (1=Spanish, 2=English, 3=French, 4=Russian, 5=Portuguese, 6=Mandarin)</param>
    /// <returns>Welcome message text</returns>
    public static string GetWelcomeMessage(int languageId)
    {
        return languageId switch
        {
            1 =>
                "¡Gracias por elegir BlueMall Puntacana como su destino de compras! Servirle es nuestra prioridad, así que déjenos sus datos para procesar su reserva de transporte, para que nuestro equipo pueda brindarle un mejor servicio. Este chat es exclusivo para reservas de traslado desde los hoteles hacia el Mall. Si desea hablar con una persona, favor marque 0",
            2 =>
                "Thank you for choosing BlueMall Puntacana as your shopping destination! Serving you is our priority, so please provide us with your information to process your transportation reservation, so our team can provide you with better service. This chat is exclusively for shuttle reservations from hotels to the Mall. If you wish to speak with a person, please dial 0",
            3 =>
                "Merci d'avoir choisi BlueMall Puntacana comme destination shopping ! Vous servir est notre priorité, alors donnez-nous vos informations pour traiter votre réservation de transport, afin que notre équipe puisse vous offrir un meilleur service. Ce chat est exclusivement pour les réservations de navette depuis les hôtels vers le Mall. Si vous souhaitez parler à une personne, veuillez composer le 0",
            4 =>
                "Спасибо за выбор BlueMall Puntacana в качестве места для покупок! Служить вам - наш приоритет, поэтому предоставьте нам свои данные для обработки вашего бронирования транспорта, чтобы наша команда могла предоставить вам лучший сервис. Этот чат предназначен исключительно для бронирования трансфера из отелей в торговый центр. Если вы хотите поговорить с человеком, наберите 0",
            5 =>
                "Obrigado por escolher o BlueMall Puntacana como seu destino de compras! Servi-lo é nossa prioridade, então nos forneça seus dados para processar sua reserva de transporte, para que nossa equipe possa oferecer um melhor serviço. Este chat é exclusivo para reservas de traslado dos hotéis para o Mall. Se desejar falar com uma pessoa, favor discar 0",
            6 =>
                "感谢您选择蓝色购物中心蓬塔卡纳作为您的购物目的地！为您服务是我们的优先考虑，所以请提供您的信息以处理您的交通预订，这样我们的团队就能为您提供更好的服务。此聊天专门用于从酒店到购物中心的班车预订。如果您希望与人交谈，请拨打0",
            _ => GetWelcomeMessage(1) // Default to Spanish
        };
    }

    /// <summary>
    /// Gets the date prompt message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Date prompt message text</returns>
    public static string GetDatePromptMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Indique la fecha en que desea realizar sus compras (Ejemplo: 25 de agosto): ",
            2 => "Please indicate the date you wish to go shopping (Example: August 25): ",
            3 => "Veuillez indiquer la date à laquelle vous souhaitez faire du shopping (Exemple : 25 août) : ",
            4 => "Укажите дату, когда вы хотите отправиться за покупками (Пример: 25 августа): ",
            5 => "Indique a data em que deseja fazer compras (Exemplo: 25 de agosto): ",
            6 => "请指明您希望购物的日期（例如：8月25日）：",
            _ => GetDatePromptMessage(1)
        };
    }

    /// <summary>
    /// Gets the zone selection message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Zone selection message text</returns>
    public static string GetZoneSelectionMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Elija la zona en la que se encuentra su hotel: ",
            2 => "Choose the zone where your hotel is located: ",
            3 => "Choisissez la zone où se trouve votre hôtel : ",
            4 => "Выберите зону, где находится ваш отель: ",
            5 => "Escolha a zona onde seu hotel está localizado: ",
            6 => "选择您酒店所在的区域：",
            _ => GetZoneSelectionMessage(1)
        };
    }

    /// <summary>
    /// Gets the hotel selection message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Hotel selection message text</returns>
    public static string GetHotelSelectionMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Elija su hotel: ",
            2 => "Choose your hotel: ",
            3 => "Choisissez votre hôtel : ",
            4 => "Выберите ваш отель: ",
            5 => "Escolha seu hotel: ",
            6 => "选择您的酒店：",
            _ => GetHotelSelectionMessage(1)
        };
    }

    /// <summary>
    /// Gets the free hotel trip message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="hotelName">Name of the hotel</param>
    /// <returns>Free hotel trip message text</returns>
    public static string GetFreeHotelTripMessage(int languageId, string hotelName)
    {
        return languageId switch
        {
            1 =>
                $"Para su hotel {hotelName} tenemos el servicio de traslado gratuito en nuestras rutas fijas con una duración de 2 horas en el Mall. El bus pasa en los siguientes horarios, elija el de su preferencia:",
            2 =>
                $"For your hotel {hotelName} we have free shuttle service on our fixed routes with a 2-hour duration at the Mall. The bus passes at the following times, choose your preference:",
            3 =>
                $"Pour votre hôtel {hotelName} nous avons un service de navette gratuit sur nos itinéraires fixes avec une durée de 2 heures au Mall. Le bus passe aux heures suivantes, choisissez votre préférence :",
            4 =>
                $"Для вашего отеля {hotelName} у нас есть бесплатный трансфер по фиксированным маршрутам продолжительностью 2 часа в торговом центре. Автобус ходит в следующее время, выберите наиболее удобное:",
            5 =>
                $"Para seu hotel {hotelName} temos serviço de traslado gratuito em nossas rotas fixas com duração de 2 horas no Mall. O ônibus passa nos seguintes horários, escolha sua preferência:",
            6 => $"对于您的酒店{hotelName}，我们在固定路线上提供免费班车服务，在购物中心停留2小时。班车在以下时间通过，请选择您的偏好：",
            _ => GetFreeHotelTripMessage(1, hotelName)
        };
    }

    /// <summary>
    /// Gets the VIP hotel trip message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="hotelName">Name of the hotel</param>
    /// <returns>VIP hotel trip message text</returns>
    public static string GetVipHotelTripMessage(int languageId, string hotelName)
    {
        return languageId switch
        {
            1 =>
                $"Para su hotel {hotelName} no tenemos el servicio de traslado gratuito, pero le podemos ofrecer nuestro servicio VIP, con una duración de 2 horas en el Mall. Nuestras reservas VIP tienen un costo general de 20 USD$ por un mínimo de 4 personas. En caso de que vengan menos de 4, pagan el total de 4 como monto mínimo. A partir de 4 personas se cobrará 5 USD$ por cada persona adicional que se agregue. Esto les cubre ida y vuelta.",
            2 =>
                $"For your hotel {hotelName} we don't have free shuttle service, but we can offer you our VIP service, with a 2-hour duration at the Mall. Our VIP reservations have a general cost of 20 USD$ for a minimum of 4 people. In case fewer than 4 come, they pay the total of 4 as the minimum amount. From 4 people onwards, 5 USD$ will be charged for each additional person added. This covers round trip.",
            3 =>
                $"Pour votre hôtel {hotelName} nous n'avons pas de service de navette gratuit, mais nous pouvons vous offrir notre service VIP, avec une durée de 2 heures au Mall. Nos réservations VIP ont un coût général de 20 USD$ pour un minimum de 4 personnes. Au cas où moins de 4 viennent, ils paient le total de 4 comme montant minimum. À partir de 4 personnes, 5 USD$ seront facturés pour chaque personne supplémentaire ajoutée. Cela couvre l'aller-retour.",
            4 =>
                $"Для вашего отеля {hotelName} у нас нет бесплатного трансфера, но мы можем предложить вам наш VIP-сервис продолжительностью 2 часа в торговом центре. Наши VIP-бронирования стоят 20 долларов США минимум для 4 человек. Если приедет меньше 4 человек, они платят общую сумму за 4 человека как минимальную сумму. Начиная с 4 человек, за каждого дополнительного человека взимается 5 долларов США. Это покрывает поездку туда и обратно.",
            5 =>
                $"Para seu hotel {hotelName} não temos serviço de traslado gratuito, mas podemos oferecer nosso serviço VIP, com duração de 2 horas no Mall. Nossas reservas VIP têm um custo geral de 20 USD$ por um mínimo de 4 pessoas. Caso venham menos de 4, pagam o total de 4 como valor mínimo. A partir de 4 pessoas será cobrado 5 USD$ por cada pessoa adicional que se agregue. Isso cobre ida e volta.",
            6 =>
                $"对于您的酒店{hotelName}，我们没有免费班车服务，但我们可以为您提供VIP服务，在购物中心停留2小时。我们的VIP预订一般费用为20美元，最少4人。如果少于4人，按4人的总费用作为最低金额付费。从4人开始，每增加一人收费5美元。这包括往返费用。",
            _ => GetVipHotelTripMessage(1, hotelName)
        };
    }

    /// <summary>
    /// Gets the reservation details request message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Reservation details request message text</returns>
    public static string GetReservationDetailsMessage(int languageId)
    {
        return languageId switch
        {
            1 =>
                "Para hacer su reserva, indique los siguientes datos:\nIndique su nombre completo\nIndique su número de habitación\nIndique la cantidad de adultos\nIndique la cantidad de niños\nIndique su número de teléfono\nIndique su E-Mail",
            2 =>
                "To make your reservation, please provide the following information:\nProvide your full name\nProvide your room number\nProvide the number of adults\nProvide the number of children\nProvide your phone number\nProvide your E-Mail",
            3 =>
                "Pour faire votre réservation, veuillez fournir les informations suivantes :\nFournissez votre nom complet\nFournissez votre numéro de chambre\nFournissez le nombre d'adultes\nFournissez le nombre d'enfants\nFournissez votre numéro de téléphone\nFournissez votre E-Mail",
            4 =>
                "Чтобы сделать бронирование, укажите следующую информацию:\nУкажите ваше полное имя\nУкажите номер вашей комнаты\nУкажите количество взрослых\nУкажите количество детей\nУкажите ваш номер телефона\nУкажите ваш E-Mail",
            5 =>
                "Para fazer sua reserva, indique os seguintes dados:\nIndique seu nome completo\nIndique seu número de quarto\nIndique a quantidade de adultos\nIndique a quantidade de crianças\nIndique seu número de telefone\nIndique seu E-Mail",
            6 => "要进行预订，请提供以下信息：\n提供您的全名\n提供您的房间号\n提供成人数量\n提供儿童数量\n提供您的电话号码\n提供您的电子邮件",
            _ => GetReservationDetailsMessage(1)
        };
    }

    /// <summary>
    /// Gets the unknown hotel message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Unknown hotel message text</returns>
    public static string GetUnknownHotelMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Por favor, indique el nombre del hotel donde se encuentra",
            2 => "Please indicate the name of the hotel where you are staying",
            3 => "Veuillez indiquer le nom de l'hôtel où vous séjournez",
            4 => "Пожалуйста, укажите название отеля, где вы остановились",
            5 => "Por favor, indique o nome do hotel onde está hospedado",
            6 => "请说明您入住的酒店名称",
            _ => GetUnknownHotelMessage(1)
        };
    }

    /// <summary>
    /// Gets the no matching hotel message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>No matching hotel message text</returns>
    public static string GetNoMatchingHotelMessage(int languageId)
    {
        return languageId switch
        {
            1 =>
                "No se ha podido encontrar el hotel indicado. La conversación se le transferirá a un miembro de equipo para que le pueda ayudar.",
            2 =>
                "The indicated hotel could not be found. The conversation will be transferred to a team member who can help you.",
            3 =>
                "L'hôtel indiqué n'a pas pu être trouvé. La conversation sera transférée à un membre de l'équipe qui pourra vous aider.",
            4 => "Указанный отель не найден. Разговор будет передан члену команды, который сможет вам помочь.",
            5 =>
                "Não foi possível encontrar o hotel indicado. A conversa será transferida para um membro da equipe que poderá ajudá-lo.",
            6 => "找不到指定的酒店。对话将转接给能够帮助您的团队成员。",
            _ => GetNoMatchingHotelMessage(1)
        };
    }

    /// <summary>
    /// Gets the ask for name message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for name message text</returns>
    public static string GetAskForNameMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Indique su nombre completo",
            2 => "Please provide your full name",
            3 => "Veuillez fournir votre nom complet",
            4 => "Укажите ваше полное имя",
            5 => "Indique seu nome completo",
            6 => "请提供您的全名",
            _ => GetAskForNameMessage(1)
        };
    }

    /// <summary>
    /// Gets the ask for room number message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for room number message text</returns>
    public static string GetAskForRoomNumberMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Indique su número de habitación",
            2 => "Please provide your room number",
            3 => "Veuillez fournir votre numéro de chambre",
            4 => "Укажите номер вашей комнаты",
            5 => "Indique seu número de quarto",
            6 => "请提供您的房间号",
            _ => GetAskForRoomNumberMessage(1)
        };
    }

    /// <summary>
    /// Gets the ask for adults count message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for adults count message text</returns>
    public static string GetAskForAdultsCountMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Indique la cantidad de adultos",
            2 => "Please indicate the number of adults",
            3 => "Veuillez indiquer le nombre d'adultes",
            4 => "Укажите количество взрослых",
            5 => "Indique a quantidade de adultos",
            6 => "请说明成人数量",
            _ => GetAskForAdultsCountMessage(1)
        };
    }

    /// <summary>
    /// Gets the ask for children count message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for children count message text</returns>
    public static string GetAskForChildrenCountMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Indique la cantidad de niños",
            2 => "Please indicate the number of children",
            3 => "Veuillez indiquer le nombre d'enfants",
            4 => "Укажите количество детей",
            5 => "Indique a quantidade de crianças",
            6 => "请说明儿童数量",
            _ => GetAskForChildrenCountMessage(1)
        };
    }

    /// <summary>
    /// Gets the ask for email message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Ask for email message text</returns>
    public static string GetAskForEmailMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Indique su E-Mail",
            2 => "Please provide your E-Mail",
            3 => "Veuillez fournir votre E-Mail",
            4 => "Укажите ваш E-Mail",
            5 => "Indique seu E-Mail",
            6 => "请提供您的电子邮件",
            _ => GetAskForEmailMessage(1)
        };
    }

    /// <summary>
    /// Gets the reservation confirmation message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <param name="date">Reservation date</param>
    /// <param name="time">Reservation time</param>
    /// <returns>Reservation confirmation message text</returns>
    public static string GetReservationConfirmationMessage(int languageId, string date, string time)
    {
        return languageId switch
        {
            1 =>
                $"*¡Reserva confirmada para el {date} a las {time}*! Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual.",
            2 =>
                $"*Reservation confirmed for {date} at {time}*! Your meeting point will be at the Hotel Lobby. Please be punctual.",
            3 =>
                $"*Réservation confirmée pour le {date} à {time}*! Votre point de rendez-vous sera au Lobby de l'Hôtel. Veuillez être ponctuel.",
            4 =>
                $"*Бронирование подтверждено на {date} в {time}*! Ваша точка встречи будет в лобби отеля. Пожалуйста, будьте пунктуальны.",
            5 =>
                $"*Reserva confirmada para {date} às {time}*! Seu ponto de encontro será no Lobby do Hotel. Por favor seja pontual.",
            6 => $"*预订确认于{date} {time}*！您的会面地点将在酒店大堂。请准时。",
            _ => GetReservationConfirmationMessage(1, date, time)
        };
    }

    /// <summary>
    /// Gets the trip full message in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Trip full message text</returns>
    public static string GetTripFullMessage(int languageId)
    {
        return languageId switch
        {
            1 =>
                "Lo sentimos, este viaje ya ha alcanzado su capacidad máxima. Por favor, seleccione otro horario o intente en otro día.",
            2 =>
                "We're sorry, this trip has already reached its maximum capacity. Please select another time or try another day.",
            3 =>
                "Nous sommes désolés, ce voyage a déjà atteint sa capacité maximale. Veuillez sélectionner une autre heure ou essayer un autre jour.",
            4 =>
                "Извините, эта поездка уже достигла максимальной вместимости. Пожалуйста, выберите другое время или попробуйте в другой день.",
            5 =>
                "Lamentamos, esta viagem já atingiu sua capacidade máxima. Por favor, selecione outro horário ou tente em outro dia.",
            6 => "抱歉，这次行程已达到最大容量。请选择其他时间或尝试其他日期。",
            _ => GetTripFullMessage(1)
        };
    }

    /// <summary>
    /// Gets the "I don't know" option text in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>"I don't know" text</returns>
    public static string GetIDontKnowText(int languageId)
    {
        return languageId switch
        {
            1 => "No lo sé",
            2 => "I don't know",
            3 => "Je ne sais pas",
            4 => "Я не знаю",
            5 => "Não sei",
            6 => "我不知道",
            _ => GetIDontKnowText(1)
        };
    }

    /// <summary>
    /// Gets the "Not in the list" option text in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>"Not in the list" text</returns>
    public static string GetNotInListText(int languageId)
    {
        return languageId switch
        {
            1 => "No está en la lista",
            2 => "Not in the list",
            3 => "Pas dans la liste",
            4 => "Не в списке",
            5 => "Não está na lista",
            6 => "不在列表中",
            _ => GetNotInListText(1)
        };
    }

    /// <summary>
    /// Gets the "I'll write later" option text in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>"I'll write later" text</returns>
    public static string GetWriteLaterText(int languageId)
    {
        return languageId switch
        {
            1 => "Escribiré luego.",
            2 => "I'll write later.",
            3 => "J'écrirai plus tard.",
            4 => "Я напишу позже.",
            5 => "Escreverei depois.",
            6 => "我稍后写。",
            _ => GetWriteLaterText(1)
        };
    }

    /// <summary>
    /// Gets the interactive button labels in the specified language
    /// </summary>
    /// <param name="languageId">Language ID</param>
    /// <returns>Button labels object</returns>
    public static InteractiveButtonLabels GetButtonLabels(int languageId)
    {
        return languageId switch
        {
            1 => new InteractiveButtonLabels
            {
                Languages = "Idiomas",
                Zones = "Zonas", 
                Hotels = "Hoteles",
                Schedules = "Horarios",
                Quantity = "Cantidad",
                Options = "Opciones",
                GroupSize = "Tamaño del Grupo"
            },
            2 => new InteractiveButtonLabels
            {
                Languages = "Languages",
                Zones = "Zones",
                Hotels = "Hotels", 
                Schedules = "Schedules",
                Quantity = "Quantity",
                Options = "Options",
                GroupSize = "Group Size"
            },
            3 => new InteractiveButtonLabels
            {
                Languages = "Langues",
                Zones = "Zones",
                Hotels = "Hôtels",
                Schedules = "Horaires",
                Quantity = "Quantité"
            },
            4 => new InteractiveButtonLabels
            {
                Languages = "Языки",
                Zones = "Зоны",
                Hotels = "Отели",
                Schedules = "Расписания",
                Quantity = "Количество"
            },
            5 => new InteractiveButtonLabels
            {
                Languages = "Idiomas",
                Zones = "Zonas",
                Hotels = "Hotéis",
                Schedules = "Horários",
                Quantity = "Quantidade"
            },
            6 => new InteractiveButtonLabels
            {
                Languages = "语言",
                Zones = "区域",
                Hotels = "酒店",
                Schedules = "时间表",
                Quantity = "数量"
            },
            _ => GetButtonLabels(1)
        };
    }

    public static string GetYesText(int languageId)
    {
        return languageId switch
        {
            1 => "Sí, por favor",
            2 => "Yes, please",
            3 => "Oui, s'il vous plaît",
            4 => "Да, пожалуйста",
            5 => "Sim, por favor",
            6 => "是的，请",
            _ => GetYesText(1)
        };
    }

    public static string GetGroupSizeSelectionMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Elija la cantidad de personas para su grupo:",
            2 => "Choose the number of people for your group:",
            3 => "Choisissez le nombre de personnes pour votre groupe:",
            4 => "Выберите количество людей для вашей группы:",
            5 => "Escolha o número de pessoas para o seu grupo:",
            6 => "选择您团体的人数：",
            _ => GetGroupSizeSelectionMessage(1)
        };
    }

    public static string GetSmallGroupText(int languageId)
    {
        return languageId switch
        {
            1 => "Menos de 15 personas (15 US$ por persona, mínimo 13)",
            2 => "Less than 15 people (15 USD per person, minimum 13)",
            3 => "Moins de 15 personnes (15 USD par personne, minimum 13)",
            4 => "Менее 15 человек (15 долларов США за человека, минимум 13)",
            5 => "Menos de 15 pessoas (15 USD por pessoa, mínimo 13)",
            6 => "少于15人（每人15美元，最少13人）",
            _ => GetSmallGroupText(1)
        };
    }

    public static string GetLargeGroupText(int languageId)
    {
        return languageId switch
        {
            1 => "Más de 15 personas (15 US$ por persona, mínimo 22)",
            2 => "More than 15 people (15 USD per person, minimum 22)",
            3 => "Plus de 15 personnes (15 USD par personne, minimum 22)",
            4 => "Более 15 человек (15 долларов США за человека, минимум 22)",
            5 => "Mais de 15 pessoas (15 USD por pessoa, mínimo 22)",
            6 => "超过15人（每人15美元，最少22人）",
            _ => GetLargeGroupText(1)
        };
    }

    public static string GetMultipleHotelMatchMessage(int languageId)
    {
        return languageId switch
        {
            1 => "Encontré varios hoteles que coinciden. Por favor seleccione el correcto:",
            2 => "I found several matching hotels. Please select the correct one:",
            3 => "J'ai trouvé plusieurs hôtels correspondants. Veuillez sélectionner le bon:",
            4 => "Я нашел несколько подходящих отелей. Пожалуйста, выберите правильный:",
            5 => "Encontrei vários hotéis correspondentes. Por favor, selecione o correto:",
            6 => "我找到了几家匹配的酒店。请选择正确的一家：",
            _ => GetMultipleHotelMatchMessage(1)
        };
    }
}

/// <summary>
/// Helper class to hold interactive button labels for different languages
/// </summary>
public class InteractiveButtonLabels
{
    public string Languages { get; set; } = string.Empty;
    public string Zones { get; set; } = string.Empty;
    public string Hotels { get; set; } = string.Empty;
    public string Schedules { get; set; } = string.Empty;
    public string Quantity { get; set; } = string.Empty;
    public string Options { get; set; } = string.Empty;
    public string GroupSize { get; set; } = string.Empty;
}