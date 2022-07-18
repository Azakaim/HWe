using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Threading;

namespace Home_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region First Task
            //new create list
            List<int> list = My_List.ListCreate();
            //input console list
            Console.WriteLine("Create new list and display on PC");
            My_List.OutputList(list);
            //delite element nut equals (25 < num < 50)
          
            Console.WriteLine("Removing from the list 25 < El < 50 and displaying on the PC screen");
            Console.ReadKey();
            My_List.DelList(ref list);
            int count = 0;
            foreach (var i in list)
            {
                Console.WriteLine(i);
                Thread.Sleep(50);
                count++;
            }
            Console.WriteLine($"Number of deleted:{ 100 - count}");
            Console.ReadKey();
            #endregion
            

            
            #region Two Task
            MyDictionary.PhoneNumber();
            MyDictionary.DefindeClientPhoneNumber();
            #endregion
            

            
            #region Three Task
            HSCollection _hs = new HSCollection();
            _hs.HS();
            #endregion
            

            
            #region Four Task
            /*
            //Персона
            Person person = new Person();

            //ФИО
            Console.WriteLine("Введите Ф.И.О.: ");
            person.FIO = Console.ReadLine();

            //Адрес
            person.adress = new Adress();
            Console.WriteLine("Введите улицу: ");
            person.adress.Street = Console.ReadLine();
            Console.WriteLine("Введите номер дома: ");
            person.adress.HouseNumber = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры: ");
            person.adress.FlatNumber = Console.ReadLine();

            //Телефон
            person.phones = new Phones();
            Console.WriteLine("Введите номер мобильного тел.: ");
            person.phones.MobilePhone = Console.ReadLine();
            Console.WriteLine("Введите номер рабочего тел.: ");
            person.phones.FlatPhone = Console.ReadLine();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            Stream stream = new FileStream(@"C:\Users\user\Desktop\" + "build.xml", FileMode.Create);
            xmlSerializer.Serialize(stream,person);
            stream.Close();
            */
            //Commone XmlDOC
            XDocument xDocument = new ();
            //Person
            XElement Pers = new("Person");
            //FIO
            Console.WriteLine("Введите Ф.И.О.: ");
            string _fio = Console.ReadLine();
            XAttribute Name = new ("name",_fio);

            //Adress
            XElement xElementAdress = new("Adress");
            Console.WriteLine("Введите адрес: ");
            string _street = Console.ReadLine();
            XElement attribute_adress = new ("Street",_street);
            Console.WriteLine("Введите номер дома: ");
            string _house_num = Console.ReadLine();
            XElement attribute_HouseNumber = new ("HouseNumber", _house_num);
            Console.WriteLine("Введите номер квартиры: ");
            string _flat_num = Console.ReadLine();
            XElement attribute_flat = new ("FlatNumber",_flat_num);
            xElementAdress.Add(attribute_adress,attribute_flat);

            //Phone
            XElement Phone = new ("Phone");
            Console.WriteLine("Введите номер мобильного тел.: ");
            string _MobilePhone = Console.ReadLine();
            XElement attribute_MobilePhone = new("MobilePhone",_MobilePhone);
            Console.WriteLine("Введите номер рабочего тел.: ");
            string _FlatPhone = Console.ReadLine();
            XElement attribute_Flat_Phone = new("FlatPhone", _FlatPhone);
            Phone.Add(attribute_MobilePhone,attribute_Flat_Phone);
            
            Pers.Add(Name,xElementAdress, Phone);

            xDocument.Add(Pers);

            Stream sr = new FileStream(@"C:\Users\user\Desktop\" + "bild.xml",FileMode.Create,FileAccess.Write);
            xDocument.Save(sr);
            sr.Close();
            #endregion
        }
    }
}
