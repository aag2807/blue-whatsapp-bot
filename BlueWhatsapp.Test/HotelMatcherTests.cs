using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Utils;
using NUnit.Framework;

namespace BlueWhatsapp.Test;

[TestFixture]
public class HotelMatcherTests
{
    private IHotelMatcher _hotelMatcher = null!;
    
    [SetUp]
    public void SetUp()
    {
        List<CoreHotel> hotels =
        [
            new CoreHotel
            {
                Id = 1,
                Name = "SECRET CAP CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
            },

            new CoreHotel
            {
                Id = 2,
                Name = "HYATT ZILARA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
            },

            new CoreHotel
            {
                Id = 3,
                Name = "HYATT ZIVA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
            },

            new CoreHotel
            {
                Id = 4,
                Name = "SPORTS ILLUSTRATED",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
            },

            new CoreHotel
            {
                Id = 5,
                Name = "TRS CAP CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA A",
                RouteId = 1,
            },

            new CoreHotel
            {
                Id = 6,
                Name = "WESTIN PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA B",
                RouteId = 2,
            },

            new CoreHotel
            {
                Id = 7,
                Name = "FOUR POINTS",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA B",
                RouteId = 2,
            },

            new CoreHotel
            {
                Id = 8,
                Name = "DREAMS FLORA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
            },

            new CoreHotel
            {
                Id = 9,
                Name = "JEWEL PALM BEACH",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
            },

            new CoreHotel
            {
                Id = 10,
                Name = "SUNSCAPE COCO PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
            },

            new CoreHotel
            {
                Id = 11,
                Name = "SERENADE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
            },

            new CoreHotel
            {
                Id = 12,
                Name = "CATALONIA BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
            },

            new CoreHotel
            {
                Id = 13,
                Name = "CATALONIA ROYAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA C",
                RouteId = 3,
            },

            new CoreHotel
            {
                Id = 14,
                Name = "RIU REPUBLICA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 15,
                Name = "BAHIA PRINCIPE (BARRERA)",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 16,
                Name = "RIU PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 17,
                Name = "RIU BAMBU",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 18,
                Name = "RIU MACAO",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 19,
                Name = "RIU BAVARO",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 20,
                Name = "HARD ROCK",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = "LOBBY DE GRUPOS",
                Currency = "USD",
                RouteId = 4,
                Route = "RUTA D",
            },

            new CoreHotel
            {
                Id = 21,
                Name = "OCCIDENTAL CARIBE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 22,
                Name = "ROYALTON PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 23,
                Name = "MAJESTIC COLONIAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 24,
                Name = "MAJESTIC ELEGANCE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 25,
                Name = "MAJESTIC MIRAGE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 26,
                Name = "ROYALTON BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 27,
                Name = "IBEROSTAR PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 28,
                Name = "IBEROSTAR DOMINICANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 29,
                Name = "IBEROSTAR SELECTION BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 30,
                Name = "IBEROSTAR BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA D",
                RouteId = 4,
            },

            new CoreHotel
            {
                Id = 31,
                Name = "VISTA SOL PUNTA CANA",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 32,
                Name = "WHALA BAVARO",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 33,
                Name = "SECRETS ROYAL BEACH",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 34,
                Name = "DREAMS ROYAL BEACH",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 35,
                Name = "DREAMS ROYAL BEACH (PREFERRED)",
                Price = 0.00f,
                TravelType = TravelTypeEnum.Shuttle,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 36,
                Name = "IMPRESSIVE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 37,
                Name = "MELIA CARIBE BEACH",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 38,
                Name = "MELIA CARIBE TROPICAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 39,
                Name = "MELIA PUNTA CANA BEACH",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 40,
                Name = "PARADISUS PALMA REAL",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 41,
                Name = "LOPESAN COSTA BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 42,
                Name = "BARCELO BAVARO BEACH",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 43,
                Name = "BARCELO BAVARO PALACE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E1",
                RouteId = 5,
            },

            new CoreHotel
            {
                Id = 44,
                Name = "PUNTA CANA PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 45,
                Name = "VIK ARENA BLANCA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 46,
                Name = "OCEAN BLUE AND SAND",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 47,
                Name = "CARIBE DELUXE PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 48,
                Name = "TROPICAL DELUXE PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 49,
                Name = "BAVARO PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 50,
                Name = "OCCIDENTAL PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 51,
                Name = "GRAND BAVARO PRINCESS",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 52,
                Name = "GRAND PALLADIUM BAVARO",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 53,
                Name = "GRAND PALLADIUM PALACE",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 54,
                Name = "GRAND PALLADIUM PUNTA CANA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 55,
                Name = "GRAND PALLADIUM TRS TURQUESA",
                Price = 5.00f,
                TravelType = TravelTypeEnum.T2,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA E2",
                RouteId = 6,
            },

            new CoreHotel
            {
                Id = 56,
                Name = "ZOETRY AGUA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 57,
                Name = "EXCELLENCE PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Barrera,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 58,
                Name = "SIRENIS",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 59,
                Name = "SECRETS TIDES PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 60,
                Name = "BREATHLESS PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 61,
                Name = "DREAMS ONYX PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 62,
                Name = "JEWEL PUNTA CANA",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 63,
                Name = "ROYALTON CHIC",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 64,
                Name = "NICKELODEON",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 65,
                Name = "OCEAN EL FARO",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            },

            new CoreHotel
            {
                Id = 66,
                Name = "DREAMS MACAO",
                Price = 10.00f,
                TravelType = TravelTypeEnum.T1,
                MeetingPoint = MeetingPoint.Lobby,
                Currency = "USD",
                Route = "RUTA F",
                RouteId = 7,
            }
        ];

        _hotelMatcher = new HotelMatcher();
        _hotelMatcher.SetHotelData(hotels);
    }

    [Test]
    public void HotelMatcherShould_BeAbleToMatchHyattHotelsWhenFirstNameIsPresent()
    {
        List<HotelMatch> matches = _hotelMatcher.FindMatches("hyatt");
        
        Assert.That(matches.Count, Is.EqualTo(2));
    }
    
    [Test]
    public void HotelMatcherShould_BeAbleToMatchHyattHotelsWhenCleansedWordIsAppended()
    {
        List<HotelMatch> matches = _hotelMatcher.FindMatches("hyatt hotel");
        
        Assert.That(matches.Count, Is.EqualTo(2));
    }
}