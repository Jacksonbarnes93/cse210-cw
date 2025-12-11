public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;




    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Event: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address.GetFullAddress()}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription(string eventType)
    {
        return $"{eventType} - {_title} on {_date}";
    }
}
