using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work
{
    class HSCollection
    {

		public void HS()
        {
			HashSet<int> hs_coll = new HashSet<int>();
			
			Console.WriteLine("Введите пожалуйста число для коллекции(пустая строка - конец ввода):");
			while (true)
			{
			string string_input = Console.ReadLine();
			int.TryParse(string_input, out int num);
			if (num == 0 && string_input != "")
			{
				Console.WriteLine("Попробуйте еще раз!");
				continue;
			}


			if (!hs_coll.Contains(num) && string_input != "")
			{
				hs_coll.Add(num);
			}
			else if (hs_coll.Contains(num) && string_input != "") Console.WriteLine("Число уже имеется в коллекции или вводилось ранее!");
			else
			{
				Console.Write("Ваша колекция:");
				for (int i = 0; i < hs_coll.Count; i++)
				{
					if(i != hs_coll.Count - 1)Console.Write(hs_coll.ElementAt(i) + ",");
					else Console.Write(hs_coll.ElementAt(i) + ".");
				}
				break;
			} 
			}
		}
	}
}
