using System.Collections.Generic;
using System;

namespace CRM
{
    public class AddressBook
    {
        #region private attributes
        private List<Contact> _contacts = new List<Contact>();
        #endregion private attibutes

        #region public methods
        public void AddContacts(List<Contact> contactToAdd)
        {
            _contacts = contactToAdd;
        }

        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }
        public bool DoesExist(Contact contact)
        {
            return _contacts.Contains(contact);
        }
        public void Remove(Contact gauthier)
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}