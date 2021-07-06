using System;

namespace _1
{

    public class name 
    {
        public string inc(int hin)
        {
            return $"{hin}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            foreach (var inf in args)
            {
                Console.WriteLine(inf);
            } 
            
            //Console.WriteLine("c=="+name_.inc(3));
            Console.ReadLine();
        }
    }
}
