using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFlabOOP
{
    class Employee
    {
        //Field -> private Access Modifier
        //public 
        //internal 
        //protected
        //private
        //source:http://helpmetocode.blogspot.com/2012/02/what-are-access-modifiers-in-c.html
        private int _id;
        private string _name;
        private string _lastName;
        private string _position;

        //private string FullName()
        //{
        //    return _name + " " + _lastName;
        //}

        //properties 
        //Encapsulation 
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
            //
        }

        public string Name { get => _name; set => _name = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Position { get => _position; set => _position = value; }
    }
}
