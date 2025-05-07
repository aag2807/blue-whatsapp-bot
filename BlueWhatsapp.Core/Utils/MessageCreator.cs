using System.Text;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Messages.Interactive;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;

namespace BlueWhatsapp.Core.Utils;

public sealed class MessageCreator : IMessageCreator
{
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateWelcomeMessage(string number)
    {
        string message = $"¡Gracias por elegir BlueMall Puntacana como su destino de compras! Servirle es nuestra prioridad, así que déjenos sus datos para procesar su reserva de transporte, para que nuestro equipo pueda brindarle un mejor servicio. Este chat es exclusivo para reservas de traslado desde los hoteles hacia el Mall.";
        CoreMessageToSend model = new CoreMessageToSend(message, number);

        return model;
    }
    
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateDatePromptMessage(string number)
    {
        string message = "Indique la fecha en que desea realizar sus compras (Ejemplo: 25 de agosto): ";
        CoreMessageToSend model = new CoreMessageToSend(message, number);

        return model;
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateLanguagePromptMessage(string number)
    {
        var model = new CoreInteractiveMessage(number);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = "Elija su idioma: ";

        model.interactive.action.button = "Idiomas";
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = "Idiomas";
        section.rows = new List<Row>();

        var spanishRow = new Row()
        {
            id = "1",
            title = "Español",
        };
        var englishRow = new Row()
        {
            id = "2",
            title = "Inglés",
        };
        var frenchRow = new Row()
        {
            id = "3",
            title = "Francés",
        };
        var russianRow = new Row()
        {
            id = "4",
            title = "Ruso",
        };
        var portugueseRow = new Row()
        {
            id = "5",
            title = "Portugués",
        };
        var mandarinRow = new Row()
        {
            id = "6",
            title = "Chino Mandarín",
        };

        section.rows.AddRange(new List<Row>()
        {
            spanishRow,
            englishRow,
            frenchRow,
            russianRow,
            portugueseRow,
            mandarinRow
        });

        model.interactive.action.sections.Add(section);

        return model;
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateSelectHotelZoneLocationMessage(string number, IEnumerable<CoreRoute> routes)
    {
        var model = new CoreInteractiveMessage(number);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = "Elija la zona en la que se encuentra su hotel: ";

        model.interactive.action.button = "Zonas";
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = "Zonas";
        section.rows = new List<Row>();
        
        List<Row> tempRows = routes.Select(route => new Row() { id = route.Id.ToString(), title = route.Description, }).ToList();

        Row iDontKnowRow = new Row()
        {
            id = "0",
            title = "No lo sé",
        };

        tempRows.Add(iDontKnowRow);

        section.rows.AddRange(tempRows);

        model.interactive.action.sections.Add(section);

        return model;
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateHotelSelectionMessage(string number, IEnumerable<CoreHotel> hotels)
    {
        var model = new CoreInteractiveMessage(number);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = "Elija su hotel: ";

        model.interactive.action.button = "Hoteles";
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = "Hoteles";
        section.rows = new List<Row>();
        List<Row> temRows = hotels.Select(hotel => new Row() { id = hotel.Id.ToString(), title = hotel.Name, }).ToList();

        section.rows.AddRange(temRows);

        model.interactive.action.sections.Add(section);

        return model;
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateTimeFrameSelectionMessage(string number, CoreHotel hotel, IEnumerable<CoreSchedule> schedules)
    {
        CoreInteractiveMessage model = new CoreInteractiveMessage(number);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = $"elija el horarios de su preferencia:";

        model.interactive.action.button = "Horarios";
        model.interactive.action.sections = new List<Section>();

        Section section = new Section();
        section.title = "Horarios";
        section.rows = new List<Row>();
        
        List<Row> tempRows = schedules.Select(schedule => new Row() { id = schedule.Id.ToString(), title = schedule.Time, }).ToList();

        tempRows.Add(new Row() {  id = "0", title = "Escribiré luego.", });

        section.rows.AddRange( tempRows );

        model.interactive.action.sections.Add(section);

        return model;
    }
 
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskForReservationDetailsMessage(string userNumber)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Para hacer su reserva, indique los siguientes datos:");
        sb.AppendLine("Indique su nombre completo");
        sb.AppendLine("Indique su número de habitación");
        sb.AppendLine("Indique la cantidad de adultos");
        sb.AppendLine("Indique la cantidad de niños");
        sb.AppendLine("Indique su número de teléfono");
        sb.AppendLine("Indique su E-Mail");
        
        CoreMessageToSend model = new CoreMessageToSend(sb.ToString(), userNumber);

        return model;
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskingForNameMessage(string userNumber)
    {
        string message = $"Indique su nombre completo";
        CoreMessageToSend model = new CoreMessageToSend(message, userNumber);

        return model;
    }
    
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskingForRoomNumberMessage(string userNumber)
    {
        string message = $"Indique su número de habitación";
        CoreMessageToSend model = new CoreMessageToSend(message, userNumber);

        return model;
    }
    
    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateAskingForAdultsMessage(string userNumber)
    {
        var model = new CoreInteractiveMessage(userNumber);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = "Indique la cantidad de adultos";

        model.interactive.action.button = "Cantidad";
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = "Cantidad";
        section.rows = new List<Row>();
        var tempRows = new List<Row>();
        for (int i = 0; i < 9; i++)
        {
            var row = new Row()
            {
                id = i.ToString(),
                title = $"{i}",
            };
            tempRows.Add(row);
        }

        section.rows.AddRange( tempRows );
        model.interactive.action.sections.Add(section);

        return model;
    }
    
    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateAskingAskingForChildrenMessage(string userNumber)
    {
        var model = new CoreInteractiveMessage(userNumber);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = "Indique la cantidad de niños";

        model.interactive.action.button = "Cantidad";
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = "Cantidad";
        section.rows = new List<Row>();
        var tempRows = new List<Row>();
        for (int i = 0; i < 9; i++)
        {
            var row = new Row()
            {
                id = i.ToString(),
                title = $"{i}",
            };
            tempRows.Add(row);
        }

        section.rows.AddRange( tempRows );
        model.interactive.action.sections.Add(section);

        return model;
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskingEmailMessage(string userNumber)
    {
        string message = $"Indique su E-Mail";
        CoreMessageToSend model = new CoreMessageToSend(message, userNumber);

        return model;
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateReservationConfirmationMessage(string userNumber, CoreHotel hotel, CoreSchedule schedule, string date)
    {
        string message = $"*¡Reserva confirmada para el {date} a las {schedule.Time}*! Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual.";
        CoreMessageToSend model = new CoreMessageToSend(message, userNumber);

        return model;
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateTripFullMessage(string userNumber)
    {
        string message = "Lo sentimos, este viaje ya ha alcanzado su capacidad máxima. Por favor, seleccione otro horario o intente en otro día.";
        CoreMessageToSend model = new CoreMessageToSend(message, userNumber);

        return model;
    }
}