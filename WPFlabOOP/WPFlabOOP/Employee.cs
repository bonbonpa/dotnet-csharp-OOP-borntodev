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

        public Employee(int id,string name ,string lastname,string position)
        {
            //constructor
            Id = id;
            Name = name;
            LastName = lastname;
            Position = position;
            //set value
        }
        public Employee(int id , string name,string position):this()  //ให้ทำงานที่ Employee ก่อน
        {
            Id = id;
            Name = name;
            Position = position;
        }
        //Overloading Same Method not same parameter
        public Employee()
        {
            Id = 0;
            Name = "undefinded";
            LastName = "undefinded";
            Position = "undefinded";
        }
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
