// Violating DIP
public class Emailer
{
    public void SendEmail()
    {
        // Send email
    }
}

public class Notification
{
    private Emailer _emailer;

    public Notification()
    {
        _emailer = new Emailer();
    }

    public void PromotionalNotification()
    {
        _emailer.SendEmail();
    }
}

// Applying DIP
public interface IMessageService
{
    void SendMessage();
}

public class Emailer : IMessageService
{
    public void SendMessage()
    {
        // Send email
    }
}

public class SMS : IMessageService
{
    public void SendMessage()
    {
        // Send SMS
    }
}

public class Notification
{
    private IMessageService _messageService;

    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void DoNotify()
    {
        _messageService.SendMessage();
    }
}