using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace epam1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine(new string('-', 50));
            Item iname = new Item("Телефон Samsung",100,5);
            Console.WriteLine(iname.ToString());
            Console.WriteLine("Общая стоимость товара = {0}",iname.GetTotalprice());

            Console.WriteLine(new string('-', 50));

            Item iname1 = new Item("Телефон HTC", 90, 5);
            Console.WriteLine(iname1.ToString());
            Console.WriteLine("Общая стоимость товара = {0}", iname1.GetTotalprice());

            Console.WriteLine(new string('-', 50));

            ArrayList arrayitem = new ArrayList();
            arrayitem.Add(iname.GetTotalprice());
            arrayitem.Add(iname1.GetTotalprice());
            int sum = 0;
            foreach (int ai in arrayitem)
            {
                sum += ai;
            }
            Console.WriteLine("Общая стоимость товаров = {0}", sum);

            Console.WriteLine(new string('-', 50));

            int x=100;
            ArrayList myarray = Item.NewArrayCollection(x);
            Item.WriteMyNewArrayCollection(myarray);

           Console.ReadKey();
        }
    }
}
