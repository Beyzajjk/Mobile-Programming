using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application1
{
    public class NameSurname
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        
        public string PhoneNumber { get; set; }

        public string Gender { get; set; }

        public string CheckBox { get; set; }

        public NameSurname(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }



    }
}
