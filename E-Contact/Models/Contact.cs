using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Contact.Models
{
    internal class Contact
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string UrlPhoto { get; set; }
        public char Genre { get; set; }
        public DateTime DateNaiss { get; set; }

        public Contact(string nomComplet, string tel, string email, string urlPhoto, char genre, DateTime dateNaiss)
        {
            NomComplet = nomComplet;
            Tel = tel;
            Email = email;
            UrlPhoto = urlPhoto;
            Genre = genre;
            DateNaiss = dateNaiss;
        }

        public Contact()
        {
        }
    }
}
