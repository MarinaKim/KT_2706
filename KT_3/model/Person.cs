using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_3.model
{
    public class Person : Human
    {
        readonly int mp = 56; // поле чтения, почти как константа, ее возможно изменить в конструкторе
        public Person()
        {
            mp = 89;
            age = 23;
        }

        public DateTime dob { get; set; }
        public int age { get; } // авто свойство , ограничили на изменение данного св-ва, поместить значение можно в конструкторе
        //private int iin; //переменная
        public int month;
        private string FullName_;
       
        public string FullName {
            get
            {
                return FullName_;
            }
            set
            {
                FullName_ = value;
                ShortName = string.Format( "{0} {1}.",value.Substring(0, value.IndexOf(' ')),value.Substring(value.IndexOf(' ')+1,1));
            }
        }

        public string ShortName { get; private set; }

        private int iin_;
        private int iin
        {
            get {return iin_; }
            set
            {
                if (value < 0)
                    iin_ = 0;
                else
                    iin_ = value;                 
            }
        }
        public void HaveBrain()
        {
            Console.WriteLine(Brain);
        }
    }

    public class Human
    {
       public bool Brain { get; protected set; }
    }
}
