using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Home_Work
{
    class MyDictionary
    {
        static Dictionary<string, List<string>> DictionaryMy = new Dictionary<string, List<string>>();
        static List<string> number;
        public static void PhoneNumber()
        {
            string input_client_name = String.Empty;
            Case:
            Console.WriteLine("Введите Ф.И.О. владельца номера: ");
            input_client_name = Console.ReadLine().Trim().ToLower();
            if (!DictionaryMy.ContainsKey(input_client_name))
            { number = new List<string>(); }
            if (input_client_name == String.Empty || input_client_name == " ")
            {
                Console.Write("Вы ничего не ввели,попробуйте снова.");
                goto Case;// if string is emphty; 
            }
            else
            {
                PhoneNums();
                try
                {
                    DictionaryMy.Add(input_client_name,number); 
                }
                catch (ArgumentException) {}
            }
            Console.WriteLine("Хотите добавить пользователя? : да/нет");
            string inp_more_1 = Console.ReadLine().Trim().ToLower();
            switch (inp_more_1)
            {
                case "да":
                    goto Case;
                default: break;
            }
        }
        public static void PhoneNums()
        {
            string string_inp = String.Empty;
            Console.WriteLine("Введите ваш номер телефона"+"\r\n*окончанием ввода считается пустая строка:");
            string inp_reg = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
            do
            {
            string_inp = Console.ReadLine().Trim().ToLower();
            if (Regex.IsMatch(string_inp, inp_reg)) number.Add(string_inp);
            else if ((string_inp == "" || string_inp == " ") && number.Count == 0) Console.WriteLine("Попробуйте снова.");
            } while ((string_inp == "" || string_inp == " ") && number.Count == 0);
            
        }
        public static void DefindeClientPhoneNumber()
        {
            Case:
            Console.WriteLine("Выберете одного из пользователей,что бы увидеть номера пользователей:");
            foreach (var item in DictionaryMy.Keys)
            {
                Console.WriteLine(item);
            }
            string client_inp = Console.ReadLine().Trim().ToLower();

            foreach (var item in DictionaryMy.Keys)
            {
                if (client_inp == item)
                {
                    foreach (var value in DictionaryMy.Values)
                    {
                        var val = value;
                        if (DictionaryMy.TryGetValue(item, out val))
                        {
                            var value_dist = val.Distinct().ToList();
                            for (int y = 0; y < value_dist.Count; y++)
                            {
                                Console.WriteLine($"Номер пользователя :{value_dist.ElementAt(y)}");
                            }
                            break;
                        }
                    }
                }
                else if(!DictionaryMy.TryGetValue(client_inp,out number)){ Console.WriteLine("Такого пользователя не существует");goto Case/*if user does not exist*/; }
            }
        }
    }
}
