namespace ContactList.Addresses
{
  public class Address
  {
    private string _address;
    private string _city;
    private string _state;
    private int _zip;

    public Address(string address, string city, string state, int zip)
    {
      _address =  address;
      _city = city;
      _state = state;
      _zip = zip;
    }

    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string address)
    {
      _address = address;
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
      return _address;
    }
    public void SetState(string state)
    {
      _state = state;
    }
    public string GetZip()
    {
      return _zip;
    }
    public void SetZip(int zip)
    {
      _zip = zip;
    }
  }
}