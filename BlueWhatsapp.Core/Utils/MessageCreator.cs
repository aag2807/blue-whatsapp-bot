using System.Text;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Messages.Interactive;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;

namespace BlueWhatsapp.Core.Utils;

public sealed class MessageCreator : IMessageCreator
{
    /// <summary>
    /// Gets the language ID from the conversation context, defaulting to Spanish (1) if not set
    /// </summary>
    private int GetLanguageId(string languageId)
    {
        return int.TryParse(languageId, out int langId) ? langId : 1; // Default to Spanish
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateWelcomeMessage(string number)
    {
        // Use default language (Spanish) for welcome message since language hasn't been selected yet
        string message = MultilingualMessageService.GetWelcomeMessage(1);
        return new CoreMessageToSend(message, number);
    }
    
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateDatePromptMessage(string number, int languageId = 1)
    {
        string message = MultilingualMessageService.GetDatePromptMessage(languageId);
        return new CoreMessageToSend(message, number);
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateLanguagePromptMessage(string number)
    {
        var model = new CoreInteractiveMessage(number);
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = "Elija su idioma | Choose your language | Choisissez votre langue | Выберите язык | Escolha seu idioma | 选择您的语言";

        model.interactive.action.button = "Languages | Idiomas";
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = "Languages";
        section.rows = new List<Row>
        {
            new Row { id = "1", title = "Español" },
            new Row { id = "2", title = "English" },
            new Row { id = "3", title = "Français" },
            new Row { id = "4", title = "Русский" },
            new Row { id = "5", title = "Português" },
            new Row { id = "6", title = "中文" }
        };

        model.interactive.action.sections.Add(section);
        return model;
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateSelectHotelZoneLocationMessage(string number, IEnumerable<CoreRoute> routes, int languageId = 1)
    {
        var model = new CoreInteractiveMessage(number);
        var buttonLabels = MultilingualMessageService.GetButtonLabels(languageId);
        
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = MultilingualMessageService.GetZoneSelectionMessage(languageId);

        model.interactive.action.button = buttonLabels.Zones;
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = buttonLabels.Zones;
        section.rows = new List<Row>();
        
        List<Row> tempRows = routes.Select(route => new Row 
        { 
            id = route.Id.ToString(), 
            title = route.Description 
        }).ToList();

        tempRows.Add(new Row
        {
            id = "99",
            title = MultilingualMessageService.GetIDontKnowText(languageId)
        });

        section.rows.AddRange(tempRows);
        model.interactive.action.sections.Add(section);

        return model;
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateHotelSelectionMessage(string number, IEnumerable<CoreHotel> hotels, int languageId = 1)
    {
        var model = new CoreInteractiveMessage(number);
        var buttonLabels = MultilingualMessageService.GetButtonLabels(languageId);
        
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = MultilingualMessageService.GetHotelSelectionMessage(languageId);

        model.interactive.action.button = buttonLabels.Hotels;
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = buttonLabels.Hotels;
        section.rows = new List<Row>();
        
        List<Row> tempRows = hotels.Select(hotel => new Row 
        { 
            id = hotel.Id.ToString(), 
            title = hotel.Name 
        }).ToList();
       
        tempRows.Add(new Row
        {
            id = "99",
            title = MultilingualMessageService.GetNotInListText(languageId)
        });

        section.rows.AddRange(tempRows);
        model.interactive.action.sections.Add(section);

        return model;
    }

    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateTimeFrameSelectionMessage(string number, CoreHotel hotel, IEnumerable<CoreSchedule> schedules, int languageId = 1)
    {
        var model = new CoreInteractiveMessage(number);
        var buttonLabels = MultilingualMessageService.GetButtonLabels(languageId);
        
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = hotel.Price > 0 
            ? MultilingualMessageService.GetVipHotelTripMessage(languageId, hotel.Name)
            : MultilingualMessageService.GetFreeHotelTripMessage(languageId, hotel.Name);

        model.interactive.action.button = buttonLabels.Schedules;
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = buttonLabels.Schedules;
        section.rows = new List<Row>();
        
        List<Row> tempRows = schedules.Select(schedule => new Row 
        { 
            id = schedule.Id.ToString(), 
            title = schedule.Time 
        }).ToList();

        tempRows.Add(new Row 
        { 
            id = "99", 
            title = MultilingualMessageService.GetWriteLaterText(languageId)
        });

        section.rows.AddRange(tempRows);
        model.interactive.action.sections.Add(section);

        return model;
    }
 
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskForReservationDetailsMessage(string userNumber, int languageId = 1)
    {
        string message = MultilingualMessageService.GetReservationDetailsMessage(languageId);
        return new CoreMessageToSend(message, userNumber);
    }
    
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateUnknownHotelMessage(string userNumber, int languageId = 1)
    {
        string message = MultilingualMessageService.GetUnknownHotelMessage(languageId);
        return new CoreMessageToSend(message, userNumber);
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateNoMatchingHotelMessage(string userNumber, int languageId = 1)
    {
        string message = MultilingualMessageService.GetNoMatchingHotelMessage(languageId);
        return new CoreMessageToSend(message, userNumber);
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskingForNameMessage(string userNumber, int languageId = 1)
    {
        string message = MultilingualMessageService.GetAskForNameMessage(languageId);
        return new CoreMessageToSend(message, userNumber);
    }
    
    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskForRoomNumberMessage(string userNumber, int languageId = 1)
    {
        string message = MultilingualMessageService.GetAskForRoomNumberMessage(languageId);
        return new CoreMessageToSend(message, userNumber);
    }
    
    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateAskForAdultsCountMessage(string userNumber, int languageId = 1)
    {
        var model = new CoreInteractiveMessage(userNumber);
        var buttonLabels = MultilingualMessageService.GetButtonLabels(languageId);
        
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = MultilingualMessageService.GetAskForAdultsCountMessage(languageId);

        model.interactive.action.button = buttonLabels.Quantity;
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = buttonLabels.Quantity;
        section.rows = new List<Row>();
        
        for (int i = 1; i <= 8; i++) // Start from 1, not 0, for adults
        {
            section.rows.Add(new Row
            {
                id = i.ToString(),
                title = i.ToString()
            });
        }

        model.interactive.action.sections.Add(section);
        return model;
    }
    
    /// <inheritdoc />
    CoreInteractiveMessage IMessageCreator.CreateAskForChildrenCountMessage(string userNumber, int languageId = 1)
    {
        var model = new CoreInteractiveMessage(userNumber);
        var buttonLabels = MultilingualMessageService.GetButtonLabels(languageId);
        
        model.interactive.header.type = "text";
        model.interactive.header.text = "Bluemall";
        model.interactive.body.text = MultilingualMessageService.GetAskForChildrenCountMessage(languageId);

        model.interactive.action.button = buttonLabels.Quantity;
        model.interactive.action.sections = new List<Section>();

        var section = new Section();
        section.title = buttonLabels.Quantity;
        section.rows = new List<Row>();
        
        for (int i = 0; i <= 8; i++) // Children can be 0
        {
            section.rows.Add(new Row
            {
                id = i.ToString(),
                title = i.ToString()
            });
        }

        model.interactive.action.sections.Add(section);
        return model;
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateAskingEmailMessage(string userNumber, int languageId = 1)
    {
        string message = MultilingualMessageService.GetAskForEmailMessage(languageId);
        return new CoreMessageToSend(message, userNumber);
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateReservationConfirmationMessage(string userNumber, CoreHotel hotel, CoreSchedule schedule, string date, int languageId = 1)
    {
        string message = MultilingualMessageService.GetReservationConfirmationMessage(languageId, date, schedule.Time);
        return new CoreMessageToSend(message, userNumber);
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateTripFullMessage(string userNumber, int languageId = 1)
    {
        string message = MultilingualMessageService.GetTripFullMessage(languageId);
        return new CoreMessageToSend(message, userNumber);
    }

    /// <inheritdoc />
    CoreMessageToSend IMessageCreator.CreateWillTextLaterMessage(string userNumber, int languageId = 1)
    {
        string message = "Entendemos que necesita más tiempo para decidir. Cuando esté listo, puede contactarnos nuevamente para completar su reserva. ¡Gracias por su interés!";
        
        // Add this to MultilingualMessageService if needed
        switch (languageId)
        {
            case 2: // English
                message = "We understand you need more time to decide. When you're ready, you can contact us again to complete your reservation. Thank you for your interest!";
                break;
            case 3: // French
                message = "Nous comprenons que vous avez besoin de plus de temps pour décider. Quand vous êtes prêt, vous pouvez nous recontacter pour finaliser votre réservation. Merci de votre intérêt !";
                break;
            case 4: // Russian
                message = "Мы понимаем, что вам нужно больше времени для принятия решения. Когда будете готовы, вы можете связаться с нами снова, чтобы завершить бронирование. Спасибо за ваш интерес!";
                break;
            case 5: // Portuguese
                message = "Entendemos que precisa de mais tempo para decidir. Quando estiver pronto, pode contactar-nos novamente para completar a sua reserva. Obrigado pelo seu interesse!";
                break;
            case 6: // Chinese
                message = "我们理解您需要更多时间来决定。当您准备好时，可以再次联系我们完成预订。谢谢您的关注！";
                break;
        }
        
        return new CoreMessageToSend(message, userNumber);
    }
}