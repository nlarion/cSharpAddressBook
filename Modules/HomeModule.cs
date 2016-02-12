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
        Contact.Clear();
        return View["deleteContacts.cshtml"];
      };      
      Post["/contact_created"] = _ => {
        Address address = new Address(Request.Form["street"],Request.Form["city"],Request.Form["state"],Request.Form["zip"]);
        Contact newContact = new Contact(address, Request.Form["name"],Request.Form["phone"], Request.Form["email"]);
        return View["contactCreated.cshtml", newContact];
      };
      Get["/list_contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["listContacts.cshtml",allContacts];
      };
    }
  }
}