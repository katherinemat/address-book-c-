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
        var allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contact/form"] = _ => {
        return View["form.cshtml"];
      };
      Post["/contact/new"] = _ => {
        Contact newContact = new Contact(Request.Form["new-name"], Request.Form["new-phone"], Request.Form["new-address"]);
        return View["new_contact.cshtml", newContact];
      };
    }
  }
}
