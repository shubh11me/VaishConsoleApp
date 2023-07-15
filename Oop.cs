using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaish
{
    public class Oop
    {
        public string name = "Shubham";
        public int age = 21;

        public int add(int a, int b)
        {
            return a + b;
        }
        public void loack(){
            Console.WriteLine("ppp");
         }

    }

    public class animal
    {
        public string name;
        public string home;
        private string color;
        protected int weight;

        public void setColor(string co)
        {
            color = co;
        }
        public void getInfo()
        {
            Console.WriteLine("The color is "+color);
            Console.WriteLine("The name is "+name);
            Console.WriteLine("The house is "+home);
        }
    }


    public class pet:animal
    {
      public void food()
        {
            weight = 5;
            Console.WriteLine(weight);
            Console.WriteLine("The food is " + "pedigree");
        }
    }


   
}
