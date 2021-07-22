using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım.Models
{
    public abstract class User //kalıtım alan sınıflarda ortak olan sınıf özellikleri mevcuttur 
    { //abstract class olursa sadece miras vermekle görevli bir sınıf olur
        public User(string _userName,string _password)
        {
            userName = _userName;
            password = _password;
            createdDate = DateTime.Now; //zaman alındığında şuandaki değer okunacak 
            createdDate = DateTime.Now; //zaman alındığında şuandaki değer okunacak 
        }
        public string userName { get; set; }

        public string password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }
        public string phoneNumber { get; set; }

        public DateTime createdDate{ get; set; }



        public string getFullName()
        {
            return ("Ad: " + firstName + " Soyad : " + lastName);
        }
    }
}
