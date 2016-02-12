using System.Collections.Generic;
using ContactList.Addresses;

namespace ContactList.Objects
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact> {};
    private string _name;
    private string _email;
    private string _phone;
    private Address _address;
    private int _id;

    public Contact(Address address, string name = "John Smith", string phone = "555-555-5555", string email = "email@email.com")
    {
      _name = name;
      _phone = phone;
      _email = email;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }    
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string phone)
    {
      _phone = phone;
    }    
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string email)
    {
      _email = email;
    }   
    public Address GetAddress()
    {
      return _address;
    }
    public void SetEmail(Address address)
    {
      _address = address;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}