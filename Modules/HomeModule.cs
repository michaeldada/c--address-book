using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;
using System.Web;
using System;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
      return View["index.cshtml", Contact.GetAll()];
    };
      Get["/addContactForm"] = _ => {
      return View["addContactForm.cshtml"];
    };
      Get["/clearAll"] = _ => {
        Contact.ClearAll();
        return View["/contactsDeleted.cshtml"];
      };

      Get["/contact/{id}"] = parameter => {
        Contact clickedContact = Contact.GetContactById(parameter.id);
        return View["viewContact.cshtml", clickedContact];
      };
      Post["/newContactAdded"] = _ => {
        Contact addedContact = new Contact(Request.Form["name"], Request.Form["number"], Request.Form["address"]);
        return View["newContactAdded.cshtml", addedContact];
      };
}
}
}
