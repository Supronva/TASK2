using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace epam1_2
{
    class Item
    {
        private string nameGoods;// поле наименования товара
        private int priceOneGoods;// поле стоимости 1й- еденицы товара
        private int countGoods;//поле колв-о товара


        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="nameGoods">наименование товара</param>
        /// <param name="priceOneGoods">стоимость 1-й еденицы товара</param>
        /// <param name="countGoods">кол-во товара</param>
        public Item(string nameGoods, int priceOneGoods, int countGoods)
        {
            this.nameGoods = nameGoods;
            this.priceOneGoods = priceOneGoods;
            this.countGoods = countGoods;
        }
        /// <summary>
        /// свой-во наименования товара
        /// </summary>
        public string NameGoods
        {
            get { return nameGoods; }
            set { nameGoods = value; }
        }


        /// <summary>
        /// свой-во стоимости 1-й еденицы товара
        /// </summary>
        public int PriceOneGoods
        {
            get { return priceOneGoods; }
            set { priceOneGoods = value; }
        }


        /// <summary>
        /// свой-во коли-во товара
        /// </summary>
        public int CountGoods
        {
            get { return countGoods; }
            set { countGoods = value; }
        }

        /// <summary>
        /// метод возвращающий общую стоимость товара
        /// </summary>
        /// <returns></returns>
        public int GetTotalprice()
        {
            return priceOneGoods * countGoods;
        }


        public override string ToString()
        {
            return string.Format("Наименование товара = {0}\nСтоимость 1-й еденицы товара = {1}\nКол-во товара = {2}", nameGoods, priceOneGoods, countGoods);
        }



        public static ArrayList NewArrayCollection(int i)
        {
            Random r = new Random();
            ArrayList array = new ArrayList();

            for (int j = 0; j < i; j++)

                array.Add(r.Next(1, 10));
                return array;
            
        }



        public static void WriteMyNewArrayCollection(ArrayList array)
        {
            foreach (int a in array)
                Console.Write("{0}\t", a);
            Console.WriteLine("\n");
        }

    }
}
