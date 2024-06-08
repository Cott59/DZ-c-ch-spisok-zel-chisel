using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch__spisok_zel_chisel
{
    public class ContactsManager<T>where T : Contact
    {
        public List<Contact> contacts = new List<Contact>();

        public void AddContact(string name, string phoneNumber)
        {
            if (name.Count()==0)
                throw new InvalidContactException("Некорректные данные");
            else 
                if (phoneNumber.Count()!=10)
                     throw new InvalidContactException("Некорректные данные");
                else
                {
                    contacts.Add(new Contact { Name = name, PhoneNumber = phoneNumber });
                }

        }
        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        public IEnumerable<Contact> FindContactByName(string name)
        {
            var ContactByName = contacts.Where(n=>n.Name == name).ToList();
            return ContactByName;
        }


    }
}
