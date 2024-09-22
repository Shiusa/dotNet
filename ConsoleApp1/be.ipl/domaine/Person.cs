using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.be.ipl.domaine
{
    /*internal class Person
    {
    }*/
    [Serializable]
    public class Person
    {


        private static readonly long serialVersionUID = 1L;

        private readonly string _name;
        private readonly string _firstname;
        private readonly DateTime _birthDate;

        public string Name
        {
            get => _name;
        }

        public string Firstname
        {
            get => _firstname;
        }

        public string BirthDate
        {
            get
            {

                //SimpleDateFormat dateFormat = new SimpleDateFormat("dd-MM-yyyy");
                //dateFormat.setTimeZone(birthDate.getTimeZone());
                return _birthDate.ToString("dd-MM-yyyy");
                //return dateFormat.format(birthDate.getTime());
            }
        }


        public Person(string name, string firstname, DateTime birthDate)
        {
            _name = name;
            _firstname = firstname;
            _birthDate = birthDate;
        }

        //@Override
        public string toString()
        {
            /*SimpleDateFormat dateFormat = new SimpleDateFormat("dd-MM-yyyy");
            dateFormat.setTimeZone(birthDate.getTimeZone());
            return "Person [name = " + name + ", firstname = " + firstname + ", birthDate =  " + getBirthDate() + "]";*/
            return "Person [name = " + Name + ", firstname = " + Firstname + ", birthDate = " + BirthDate + "]";
        }


    }
}
