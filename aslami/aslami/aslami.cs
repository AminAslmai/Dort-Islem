using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace aslami
{
    
    public class aslami
    {
        public static double sayi2 { get; set; }
        public static double sayi1 { get; set; }
        
        public static double sayicek() { return double.Parse(Console.ReadLine()); }
        public static void yaz(string deger)
        {
            Console.Write(deger);
        }
        public static void altayaz(string deger)
        {
            Console.WriteLine(deger);

        }
        public static void durdur()
        {
            Console.ReadKey();
        }
        public static double topla(double sayi1, double sayi2)
        {

            return sayi1 + sayi2;
        }
        public static double cikar(double sayi1,double sayi2)
        {

            return sayi1 - sayi2;
        }
        public static double carp(double sayi1, double sayi2)
        {

            return sayi1 * sayi2;
        }
        public static double bol(double sayi1, double sayi2)
        {

            return sayi1 / sayi2;
        }
        public static double mod(double sayi1, double sayi2)
        {

            return sayi1 % sayi2;
        }
        public static bool eger(string sart1, string sart, string sart2)
        {
            if (sart == "<")
            {
                if (double.Parse(sart1)<double.Parse(sart2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (sart == ">")
            {
                if (double.Parse(sart1) > double.Parse(sart2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (sart == ">=")
            {
                if (double.Parse(sart1) >= double.Parse(sart2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (sart == "<=")
            {
                if (double.Parse(sart1) <= double.Parse(sart2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (sart == "!=")
            {
                if (sart1 != sart2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (sart =="==")
            {

                if (sart1 == sart2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public static void dongu (int baslangic,int bitis,int atlama,string sart,string tekrar)
        {
            if (sart =="<")
            {
                for (int i = baslangic; i < bitis; i += atlama)
                {
                    yaz(tekrar);
                }
            }
            else if (sart == ">")
            {
                for (int i = baslangic; i > bitis; i += atlama)
                {
                    yaz(tekrar);
                }
            }
            else if (sart == ">=")
            {
                for (int i = baslangic; i >= bitis; i += atlama)
                {
                    yaz(tekrar);
                }
            }
            else if (sart == "<=")
            {
                for (int i = baslangic; i <= bitis; i += atlama)
                {
                    yaz(tekrar);
                }
            }
            else if (sart == "!=")
            {
                for (int i = baslangic; i != bitis; i += atlama)
                {
                    yaz(tekrar);
                }
            }



        }
    }
}
