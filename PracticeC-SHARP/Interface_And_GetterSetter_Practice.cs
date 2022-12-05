using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_SHARP
{
    

    interface Dog
    {
        void printDogName();
        void setDogName(string name);
    }

    internal class Interface_And_GetterSetter_Practice : Dog
    {
        private string member;
        public string Property
        {
           get
            {
                return member;
            }
           set
            {
                if (!Char.IsUpper(value,0))
                {
                    string str = value.Substring(0,1).ToUpper() + value.Substring(1);
                    member = str;
                }
                else
                {
                    member = value;
                }
            }
        }

        public void setDogName(string name)
        {
            Property= name;
        }
        public void printDogName()
        {
            Console.WriteLine(Property);
        }
    }
}
