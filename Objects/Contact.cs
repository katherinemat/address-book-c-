using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, string phone, string address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      _instances.Add(this);
      _id = _instances.IndexOf(this);
    }

    public string GetName()
    {
      return _name;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public string GetAddress()
    {
      return _address;
    }

    public int GetId()
    {
      return _id;
    }
    public void SetId(int newId)
    {
      _id = newId;
    }

    public void Delete()
    {
      _instances.Remove(this);
    }

    public static void SetIds()
    {
      foreach(Contact contact in _instances)
      {
        contact.SetId(_instances.IndexOf(contact));
      }
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}
