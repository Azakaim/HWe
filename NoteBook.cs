using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    
    public struct Person
    {
        public string FIO;
        public Adress adress;
        public Phones phones;
        public Person(string FIO,Adress adress, Phones phones)
        {
            this.FIO = "";
            this.adress = new Adress();
            this.phones = new Phones();
        }
    }
    public struct Adress
    {
        public string Street;
        public string HouseNumber;
        public string FlatNumber;

        public Adress(string Street, string HouseNumber, string FlatNumber)
        {
            this.Street = "";
            this.HouseNumber = "";
            this.FlatNumber = "";
        }
    }
    public struct Phones
    {
        public string MobilePhone;
        public string FlatPhone;

        public Phones(int MobilePhone,string FlatPhone)
        {
            Console.WriteLine("Введите мобильный телефон: ");
            this.MobilePhone = Console.ReadLine();
            Console.WriteLine("Введите рабочий телефон: ");
            this.FlatPhone = Console.ReadLine();
            
        }
    }
}
