using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsDay1
{
    public class parent
    {
        public int a = 10;
        public double b = 10.00;
        public string c = "abc";
        public float d = 10.00f;
        public enum e { one, two, three, four };
        public int ExProp {get;set;}

        

        public double add()
        {
            
            double sum;
            sum = a + b;
            return sum;
        }
        
    }

    public class child : parent
    {
        public int add(int i,int j)
        {
            return i + j;
        }
        
        public string print(string inp)
        {
            switch (inp)
                {
                    case "a":
                    Console.WriteLine(a);
                    break;

                case "b":
                    Console.WriteLine(b);
                    break;
                default:
                    Console.WriteLine("Some other value");
                    break;

            }
            if(c.Equals("abc"))
            {
                Console.WriteLine("c has abc");
            }
            else
            {
                Console.WriteLine("c does not have abc");
            }
            int h = 15;
            var sol = h == 20 ? "10 is equal to 20" : "10 is not equal to 20";
            Console.WriteLine(sol);

            var count = Enum.GetNames(typeof(e)).Length;
            for (int g=0;g<=count;g++)
            {
                Console.WriteLine(g);
            }
            return ("Above printed is the value in the variable");
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            child ch = new child();
            Console.WriteLine(p.add());
            Console.WriteLine(ch.add(10, 20));
            Console.WriteLine(ch.add());
            string mc = Console.ReadLine();
            Console.WriteLine(ch.print(mc));
            p.ExProp = 123;
            Console.WriteLine(p.ExProp);
            Console.ReadLine();

        }
    }
}
