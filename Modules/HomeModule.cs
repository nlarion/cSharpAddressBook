using Nancy;
using System.Collections.Generic;
using ContactList.Objects;
using ContactList.Addresses;

namespace ContactList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
          return View["index.cshtml"];
      };
      Get["/create_contact"] = _ => {
          return View["createContact.cshtml"];
      };      
      Get["/contacts_delted"] = _ => {
          return View["deleteContacts.cshtml"];
      };      
      Post["/contact_created"] = _ => {
          return View["contactCreated.cshtml"];
      };
      Get["/list_contacts"] = _ => {
          return View["listContacts.cshtml"];
      };
    }
  }
}