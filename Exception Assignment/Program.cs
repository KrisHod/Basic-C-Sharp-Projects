﻿using System;
using System.Collections.Generic;


namespace Exception_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<int> list = new List<int>(){ 4, 7, 23, 56, 62, 4, 1, 67, 9};
            try
            {
                Console.WriteLine("Enter a number to divide each number in the list by");
            int input = Convert.ToInt32(Console.ReadLine());
            
                foreach (int i in list)
                {
                    Console.WriteLine(i / input);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter the whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0");
            }
            
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            
            finally{
                Console.WriteLine("The end :-)");
            }
            Console.ReadLine();
        }
    }
}
