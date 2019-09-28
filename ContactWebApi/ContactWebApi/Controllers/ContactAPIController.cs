using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactWebApi.Controllers
{
   

    public class ContactAPIController : ApiController
    {

        [Route("api/AjaxAPI/InsertContact")]
        [HttpPost]
        public Contact InsertContact(Contact _contact)
        {
            using (masterEntities entities = new masterEntities())
            {

                entities.Contacts.Add(_contact);
                entities.SaveChanges();
            }

            return _contact;
        }

        [Route("api/AjaxAPI/UpdateContact")]
        [HttpPut]
        public bool UpdateContact(Contact _contact)
        {
            using (masterEntities entities = new masterEntities())
            {
                Contact updatedContact = (from c in entities.Contacts
                                           where c.ContactId == _contact.ContactId
                                           select c).FirstOrDefault();
                updatedContact.FirstName = _contact.FirstName;
                updatedContact.LastName = _contact.LastName;
                updatedContact.Phone = _contact.Phone;
                updatedContact.EmailId = _contact.EmailId;
                updatedContact.Status = _contact.Status;
                entities.SaveChanges();
            }

            return true;
        }

        [Route("api/AjaxAPI/DeleteContact")]
        [HttpDelete]
        public void DeleteContact(Contact _contact)
        {
            using (masterEntities entities = new masterEntities())
            {
                Contact contact = (from c in entities.Contacts
                                     where c.ContactId == _contact.ContactId
                                    select c).FirstOrDefault();
                entities.Contacts.Remove(contact);
                entities.SaveChanges();
            }
        }
    }
}
    

