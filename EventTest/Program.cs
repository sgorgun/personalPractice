public sealed class ClassWithEvent
{
    public EventHandler<AnnouncementEventArgs>? Announcement;

    public void EventEmulation(int value, string message)
    {
        OnAnnouncement(new AnnouncementEventArgs(value, message));
    }

    private void OnAnnouncement(AnnouncementEventArgs eventArgs)
        => Announcement?.Invoke(this, eventArgs);
}

public class AnnouncementEventArgs : EventArgs
{
    public AnnouncementEventArgs(int value, string message)
        => (this.Value, this.Message) = (value, message);

    public int Value { get; set; }

    public string Message { get; set; }
}

public class Reporter
{
    public void Report(object? sender, AnnouncementEventArgs? eventArgs)
        => Console.WriteLine($"Report: {eventArgs?.Message} with value {eventArgs?.Value}.");
}

//A 
var source = new ClassWithEvent();
var reporter = new Reporter();
source.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
source.Announcement += reporter.Report;
source.EventEmulation(10, "Count");
source.Announcement -= reporter.Report;
source.EventEmulation(5, "Sum");

//B 
var source = new ClassWithEvent();
var reporter = new Reporter();
source.EventEmulation(10, "Count");
source.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
source.Announcement += reporter.Report;
source.Announcement -= reporter.Report;
source.EventEmulation(5, "Sum");

//C 
var source = new ClassWithEvent();
var reporter = new Reporter();
source.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
source.Announcement += reporter.Report;
source.EventEmulation(10, "Count");
source.Announcement -= reporter.Report;
source.Announcement -= (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
source.EventEmulation(5, "Sum");

//D 
var source = new ClassWithEvent();
var reporter = new Reporter();
source.Announcement += reporter.Report;
source.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
source.Announcement -= reporter.Report;
source.EventEmulation(10, "Count");
source.EventEmulation(5, "Sum");