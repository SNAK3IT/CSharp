using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BCrypt.Net;
using BCrypt;

namespace ContactList
{
    class user
    {
        private string id;
        public string username { get; set; } = String.Empty;
        private string _email = String.Empty;
        private string _password = String.Empty;
        private List<contacto> contactos;

        public user() {
            this.id = Guid.NewGuid().ToString();
            contactos = new List<contacto>();
        }
        //Metodos

        //public string PassCrypter(string password, bool hahing)
        //{
            
        //}

        //Propriedades
        public string Email {
            get { return _email; }
            set {
                Regex email = new Regex(@"1^\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
                if (email.IsMatch(value)){
                    _email = value;
                }else{_email = "";}
            }
        }
        public string PASSWORD {
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    
                }
            }
        }

        public string Encrypt(string password) {
            return string hash = BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
