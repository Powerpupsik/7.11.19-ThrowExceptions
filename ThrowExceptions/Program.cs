﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            try
            {
                string userData = GetData();
                var userBirthDay = GetDate(userData);
                Console.WriteLine($"You were born on {userBirthDay.DayOfWeek}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please try again");
                
            }
        }

        public static DateTime GetDate (string dateOfBirthString)
        {
            string[] userBDay = dateOfBirthString.Split('/');

            try
            {
                var dateObject = new DateTime(int.Parse(userBDay[0]), int.Parse(userBDay[1]), int.Parse(userBDay[2]));
                return dateObject;
            }
            catch(FormatException e) 
            {
                Console.WriteLine("Use correct date format: yyyy/mm/dd");
                throw;
            }
        }
        public static string GetData()
        {
            string userInput;
            Console.WriteLine("Enter ypor date of birth yyyy/mm/dd");
            return userInput = Console.ReadLine();
        }
    }
}
