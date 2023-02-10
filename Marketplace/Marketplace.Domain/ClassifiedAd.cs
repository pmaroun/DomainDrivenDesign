namespace Marketplace.Domain;

public class ClassifiedAd
{
    private UserId _ownerId;
    private decimal _price;
    private string _text;
    private string _title;

    public ClassifiedAd(ClassifiedAdId id, UserId ownerId)
    {
        Id = id;
        _ownerId = ownerId;
    }

    public ClassifiedAdId Id { get; }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void UpdateTest(string text)
    {
        _text = text;
    }

    public void UpdatePrice(decimal price)
    {
        _price = price;
    }
}