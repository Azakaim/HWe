using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Home_Work
{
    struct My_List
    {
        static Random random = new Random();

        static List<int> list_my = new List<int>();
        /// <summary>
        /// Создание List<int>
        /// </summary>
        /// <returns>List</returns>
        public static List<int> ListCreate()
        {
            
            for (int i = 0; i < 100; i++)
            {
                list_my.Add(random.Next(1,100));
            }
            return list_my;
        }
        /// <summary>
        /// Вывод List<int>
        /// </summary>
        /// <param name="list"></param>
        public static void OutputList(List<int> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                Thread.Sleep(50);
                Console.WriteLine($"{item}");count++;
            }
            Console.WriteLine($"Amount of numbers :{count}");
        }
        /// <summary>
        /// Удаление элл-ов List<int> (  25 < num < 50 )
        /// </summary>
        /// <param name="list_my"></param>
        /// <returns></returns>
        public static void DelList(ref List<int> list_my) 
        {
            
            for (int i = 0; i < list_my.Count; i++)
            {
                if (list_my.ElementAt(i) > 25 && list_my.ElementAt(i) < 50)
                {
                    list_my.Remove(i);
                }
            }
            
        }
    }
}
