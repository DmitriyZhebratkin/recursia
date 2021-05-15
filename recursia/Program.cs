using System;

namespace recursia
{
    class Program
    {  static void Example(string str)
        {  
            if(str.Length > 0)
                Example(str.Substring(1, str.Length - 1));
                else
                    return;
            Console.Write(str[0]);
            
        
         }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть речення:");
            string s = Console.ReadLine();
            Console.WriteLine("Результат:");
            Example(s);
            Console.ReadLine();

        }
    }
}
