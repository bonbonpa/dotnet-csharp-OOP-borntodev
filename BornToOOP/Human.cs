using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BornToOOP
{
    class Human
    {
        //Attribute (ตัวแปร) Adjective -> คุณศัพท์ -> ขยายนาม
        int Age;
        string Name;
        string LastName;

        //Behavior (Method,Function) กริยา Verb
        public void addAge() {
            Age++;
        }
        public  string getName()  
        {
            return Name + " " + LastName;
        }
        public void setName(string name)
        {
            this.Name = name; //this in current class
        }
        public void setLastName(string lastname)
        {
            this.LastName = lastname;
        }
    }
}
