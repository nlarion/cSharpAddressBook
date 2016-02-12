namespace ContactList.Addresses
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private int _zip;

    public Address(string street = "", string city = "Portland", string state = "Oregon", int zip = 97211)
    {
      _street =  street;
      _city = city;
      _state = state;
      _zip = zip;
    }

    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string street)
    {
      _street = street;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string city)
    {
      _city = city;
    }
    public string GetState()
    {
      return _state;
    }
    public void SetState(string state)
    {
      _state = state;
    }
    public int GetZip()
    {
      return _zip;
    }
    public void SetZip(int zip)
    {
      _zip = zip;
    }
  }
}