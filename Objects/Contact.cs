using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private static List<Contact> _instances = new List<Contact> {};
    private string _name;
    private int _id;
    private List<Phone> _phones;

    public Contact(string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.IndexOf(this);
      _phones = new List<Phone>{};
    }

    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }

    public List<Phone> GetPhones()
    {
      return _phones;
    }
    public void AddPhone(Phone phone)
    {
      _phones.Add(phone);
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
