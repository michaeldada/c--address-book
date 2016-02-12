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
      View["index.cshtml", Contact.GetAll()];
    };
      Get["/addContactForm"] = _ => {
      View["addContactForm.cshtml"];
    };

}
}
}
