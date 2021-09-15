using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    class identity
    {
        string name;
        string surname;
        string hometown;
        int age;
        char gender;

       public string NAME
        {
            get { return name; }
            set { name = value.ToLower(); }
        }
       public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }

        public string HOMETOWN
        {
            get { return hometown; }
            set { hometown = value; }
        }
        public int AGE
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }

        public char GENDER
        {
            get { return gender; }
            set { gender = value; }
        }

        public identity()
        {
            name = "";
            surname = "";
            age = 18;
            gender = 'k';
            hometown = "Ankara";
        }



    }
}
