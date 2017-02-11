using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Phone
  {
    private string _phone;
    private int _id;
    private static List<Phone> _instances = new List<Phone> {};

    public Phone(string phone)
    {
      _phone = phone;
      _instances.Add(this);
      _id = _instances.IndexOf(this);
    }

    public string GetPhone()
    {
      return _phone;
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
      foreach(Phone phone in _instances)
      {
        phone.SetId(_instances.IndexOf(phone));
      }
    }

    public static List<Phone> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Phone Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}
