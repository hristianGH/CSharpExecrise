﻿using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

           //	0-2 – baby; 
                   //3/ - 13 – child; 
            //1/4 - 19 – teenager;
             //2/0 - 65 – adult;
              //>/= 66 – elder;
  
            if (age<=2)
            {
                Console.WriteLine("baby");
            }
            else if (age <=13)
            {
                Console.WriteLine("child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age <= 65)
            {
                Console.WriteLine("adult");
            }
            else  
            {
                Console.WriteLine("elder");
            }
             
        }
    }
}
