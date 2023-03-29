using System;

namespace ConsoleApp
{
    class Program
    {
        int sk1;
        static void Main(string[] args)
        {
            /*  int a = 1;
              int b = 5;
              Console.WriteLine("Hello World!");
              Program sn = new Program();
             int c= sn.add(a, b);
              Console.WriteLine("Hello World!1" + sn.sk1) ;
              Console.WriteLine("Hello World!" +c);

              sn.Name = "Shanm";
              Console.WriteLine(sn.Name);
              Console.WriteLine("Hello World!" + sn.sk1);
              Console.WriteLine("Hello World!" + sn.sk1);
             // double sqrtNum = Math.Sqrt(16);
              Console.WriteLine(Math.Sqrt(16));
              Console.WriteLine(Math.PI);
              Console.WriteLine(Math.Pow(2,3));
              Console.WriteLine(Math.Abs(5.4));
              Console.WriteLine(Math.Ceiling(3.5));
              Console.WriteLine(Math.Floor(3.5));
              Console.WriteLine(Math.Round(3.5));
              Console.WriteLine(Math.Round(3.6));
              Console.WriteLine(Math.Round(3.4));
              Console.WriteLine(Math.Max(3,5));
              Console.WriteLine(Math.Truncate(4.6));

              Console.WriteLine(string.Concat("shan","muga"));
              Console.WriteLine(string.Compare("sh1","sh"));
              Console.WriteLine(string.Join("-","bas","sd"));*/

            sncls1 s = new sncls1();
            s.snadd1();

            string s1 = "hello world";
            string capitalized = StringExtensions.CapitalizeFirstLetter(s1);
            string capitalized1 = s1.CapitalizeFirstLetter();
            Console.WriteLine(capitalized+" "+ capitalized1);
            string capitalized2 = StringExtensions.CapitalizeFirstLetter(s1);
            Console.WriteLine(capitalized2);
        }

        private string name;
        public string Name
        {
            get { 
                return name;
            }
            set
            {

                name = value;
                name = "sk";
                sk1 = 5;
            }
        }
     

        public int add(int a, int b)
        {
            Console.WriteLine("Hello World!"+a);
            sk1 = 2;
            return a + b+sk1;
            
        }
    }
}
