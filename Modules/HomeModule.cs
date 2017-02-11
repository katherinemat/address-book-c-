using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contact/form"] = _ => {
        return View["form.cshtml"];
      };
      Post["/contact/new/form"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"]);
        return View["new_contact_form.cshtml", newContact];
      };
      Post["/phone/added"] = _ => {
        Phone newPhone = new Phone(Request.Form["new-phone"]);
        return View["phone_added.cshtml", newPhone];
      };
      //Add route for clicking on each contact to show contact/{id} page with name and phone number
    }
  }
}
