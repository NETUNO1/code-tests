using System;
namespace topicos_especiais
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            DateTime hora = DateTime.Now;
            Console.WriteLine(hora);
            TimeSpan t1 = new TimeSpan(100000000);
            DateTime t2 = new DateTime(2021, 8, 15, 13, 45, 58, 257);
            Console.WriteLine("day of year:"+t2.DayOfYear);
            Console.WriteLine("day of week:" + t2.DayOfWeek);

            
            Console.WriteLine(t1);
        }
    }
}
