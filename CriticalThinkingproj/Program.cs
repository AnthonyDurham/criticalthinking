using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingproj
{
    class Program
    {
        public static void Main(string[] args)

        {
           
            int Counter = 0;
            string input = "";

            Console.WriteLine("Please enter a number from 0 to 24");
            while (Counter < 25)
            {
                
                Counter ++;
            }


            if (int.TryParse(input, out Counter))
           

               
                input = Console.ReadLine();

            
            Console.WriteLine("input is " + input);

            Console.ReadLine();

        }

        


       

    }


}
        
        

            
        
    

