using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _number;
    private string _address;
    private int _id;
    private static List<Contact> _contactList = new List<Contact> {};

    public Contact(string name, string number, string address)
    {
      this.SetName(name);
      this.SetNumber(number);
      this.SetAddress(address);

      _id = _contactList.Count;
      _contactList.Add(this);
    }

    public string GetName()
    {
      return _name;
    }
    public string GetNumber()
    {
      return _number;
    }
    public string GetAddress()
    {
      return _address;
    }
    public int GetId()
    {
      return _id;
    }
    public void SetName(string name)
    {
      _name = name;
    }
    public void SetNumber(string number)
    {
      _number = number;
    }
    public void SetAddress(string address)
    {
      _address = address;
    }
    public static List<Contact> GetAll()
    {
      return _contactList;
    }
    public static Contact GetContactById(int id)
    {
      return _contactList[id];
    }
    public static void ClearAll()
    {
      _contactList.Clear();
    }
  }
}
