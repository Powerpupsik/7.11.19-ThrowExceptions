using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutajalt 3 värvi

            Console.WriteLine("nAME THREE COLORS: ");
            string userInput = Console.ReadLine();

            //Split eemaldab tühikud ja soovimatud märgid
            string[] colors = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> colorList = colors.ToList();
            foreach(string color in colorList)
            {
                Console.WriteLine(color);
            }
            //MILLEGI LISAMINE
            Console.WriteLine("Add /remove a color: ");
            string userAnswerToAdd = Console.ReadLine();
            string userChoice;
            
            if (userChoice.ToLower() == "add")
            {
                Console.WriteLine("Enter a color to add: ");
                string userAnswerToAdd = Console.ReadLine();
                colorList.Add(userAnswerToAdd);
            }
            else if (userChoice.ToLower() == "remove")
            {
                Console.WriteLine("Enter a color to remove: ");
                string userAnswerToRemove = Console.ReadLine();
                colorList.Remove(userAnswerToRemove);
            }
            else
            {
                Console.WriteLine("Unknown command");
            }

            foreach (string color in colorList)
            {
                Console.WriteLine(color);
            }
                

            Console.ReadLine();
        }
    }
}
