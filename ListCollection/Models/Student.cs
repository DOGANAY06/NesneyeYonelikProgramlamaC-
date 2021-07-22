using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım.Models
{
    public class Student :User
    {
         
        public Student(string _schoolNumber,string _userName, string _password) : base(_userName, _password) //anasınıfdaki özelliklerimiz
        {
            schoolNumber = _schoolNumber;
        }

        public ClassRoom classRoom{ get; set; } // 1-A burada 2 değer var bunun için ayırıp tutmak istiyorum number ve karakter olarak

    
        //bunuda ClassRoom sınıfında yapacağım
        public string schoolNumber { get; set; } //123
        //öğrencinin öğretmenleri var 
        public List<Teacher> teachers { get; set; }

        //öğrencinin dersleride var 
        public List<Lesson> lessons { get; set; }

        public void OdevYap()
        {
            MessageBox.Show("Ödev Yapılıyor");
        }

    }
}
