using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class sncls 
    {
        public sncls()
        {
            Console.WriteLine("sncls");
        }
        public void snadd()
        {
            Console.WriteLine("snadd");
        }
    }
    class sncls1
    {
        public sncls1()
        {
            Console.WriteLine("sncls1");
             snscls.snsadd();
            snslcls seld = new snslcls();
            seld.snsadd();

           // Console.WriteLine(obj.GetType());

        }
        public void snadd1()
        {
            Console.WriteLine("snadd");
        }
            }

    static class snscls
    {
        public static void snsadd()
        {
            Console.WriteLine("snsadd");
        }
    }

    sealed class snslcls :sncls
    {
        public void snsadd()
        {
            Console.WriteLine("sealdsadd");
        }
    }

    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }

    sealed class SealedClass
    {
        public static string CapitalizeFirstLetter( string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
