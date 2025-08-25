using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class ConsoleMethods
    {
        /*
         *  GetGuestName()
         *      ask for name: {name}
         *      return {name}
         *      
         *  GetNumberInParty()
         *      ask for number: {number}
         *      return {number}
         *      
         *  PrintGuestList(list)
         *      foreach {name} in {list}
         *          print {name}
         */

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to our Guestbook App.");
            Console.WriteLine("-----------------------------");
        }

        public static string GetGuestName()
        {
            Console.Write("\nWhat is your group's name: ");
            string name = Console.ReadLine();

            return name;
        }

        public static int GetGuestCount()
        {
            int number;
            bool isValidNumber;
            
            do
            {
                Console.Write("How many people are in your group: ");
                string numberString = Console.ReadLine();

                isValidNumber = int.TryParse(numberString, out number);

                if (!isValidNumber)
                {
                    Console.WriteLine("That was not a valid number.");
                } 
            } while (!isValidNumber);

            return number;
        }

        public static (List<string> guests, int totalGuests) GetGuests()
        {
            List<string> guestList = new List<string>();
            int totalGuests = 0;
            bool isDone = false;

            do
            {
                string name = ConsoleMethods.GetGuestName();
                guestList.Add(name);

                int number = ConsoleMethods.GetGuestCount();
                totalGuests += number;

                Console.Write("\nAre there more guests to add to the guestbook? (type yes or no) ");
                string hasMore = Console.ReadLine();

                if (hasMore.ToLower() == "no")
                {
                    isDone = true;
                }
            } while (!isDone);

            return (guestList, totalGuests);
        }

        public static void PrintGuestList(List<string> list)
        {
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}
