using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalıtım.Models
{
    public class Teacher:User
    {
        public Teacher(string _userName, string _password) : base(_userName, _password)
        { //generate constructor yaptık burada

        }

        public List<ClassRoom> classRooms { get; set; }

        public string branch { get; set; }
        public object Add { get; internal set; }

        public void OdevVer()
        {
            MessageBox.Show("Ödev verildi");
        }

       
    }
}
