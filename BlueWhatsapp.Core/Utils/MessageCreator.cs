using System.Text;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Messages.Interactive;
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
    CoreInteractiveMessage IMessageCreator.CreateSelectHotelZoneLocationMessage(string number)
    {
        var model = new CoreInteractiveMessage(number);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = "Elija la zona en la que se encuentra su hotel: ";

        model.interactive.action.button = "Idiomas";
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = "Zonas";
        section.rows = new List<Row>();

        var bavaroRow = new Row()
        {
            id = "1",
            title = "Bávaro",
        };
        var puntaCana = new Row()
        {
            id = "2",
            title = "Punta Cana",
        };
        var capCana = new Row()
        {
            id = "3",
            title = "Cap Cana",
        };
        var cabezaDeToro = new Row()
        {
            id = "4",
            title = "Cabeza de Toro",
        };
        var uveroAltoRow = new Row()
        {
            id = "5",
            title = "Uvero Alto",
        };
        var bayahibeRow = new Row()
        {
            id = "6",
            title = "Bayahíbe",
        };
        var romanaRow = new Row()
        {
            id = "7",
            title = "La Romana",
        };
        var idontknowRow = new Row()
        {
            id = "8",
            title = "No lo sé",
        };

        section.rows.AddRange(new List<Row>()
        {
            bavaroRow,
            puntaCana,
            capCana,
            cabezaDeToro,
            uveroAltoRow,
            bayahibeRow,
            romanaRow,
            idontknowRow
        });

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
        
        var hotel1 = new Row()
        {
            id = "1",
            title = "SECRET CAP CANA",
        };
        var hotel2 = new Row()
        {
            id = "2",
            title = "HYATT ZILARA",
        };
        var hotel3 = new Row()
        {
            id = "3",
            title = "HYATT ZIVA",
        };

        section.rows.AddRange(new List<Row>()
        {
            hotel1,
            hotel2,
            hotel3,
        });

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

        Row decideLater = new Row()
        {
            id = "99",
            title = "Escribiré luego.",
        };
        
        Row dummySchedudle = new Row()
        {
            id = "1",
            title = "09:25",
        };

        section.rows.AddRange(new List<Row>()
        {
            dummySchedudle,
            decideLater,
        });

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

    public CoreMessageToSend CreateReservationConfirmationMessage(string userNumber, CoreHotel hotel, CoreSchedule schedule, string date)
    {
        string message = $"*¡Reserva confirmada para el {date} a las {schedule.Time}*! Su punto de encuentro será en el Lobby del Hotel. Por favor estar puntual.";
        CoreMessageToSend model = new CoreMessageToSend(message, userNumber);

        return model;
    }
}