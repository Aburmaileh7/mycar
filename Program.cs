using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCars
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 12345;
            c1.Name = "Mohammad";
            c1.Type = "BMW";
            c1.Price = "5000 $ ";
            c1.printData();
            Customer c2 = new Customer();
            c2.ID = 12345;
            c2.Name = "Ali";
            c2.Type = "FEATA";
            c2.Price = "4524 $ ";
            c2.printData();
        }
    }

    public class Customer
    {
        private int _id;
        private string _name;
        private string _price;
        private string _type;
        private string MyprintData()
        {
            return "ID : " + _id + ";" +
                   "Name : " + _name + ";" +
            "Price : " + _price + ";" +
            "Type : " + _type + ";";


        }
        public void printData()
        {
            Console.WriteLine(MyprintData().Replace(";", "\n "));
        }



        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Price { get { return _price; } set { _price = value; } }
        public string Type { get { return _type; } set { _type = value; } }

    }

}
