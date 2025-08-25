/*  
 *  Ask the user for their name and how many are in their party. 
 *  Keep track of how many people are at the party. At the end, print out 
 *  the guest list and the total number of guests.
 */

/*  
 *  var for list: {guestList}
 *  var for total: {totalGuests}
 *  var for loop: {isDone}
 *  
 *  do
 *      ask for name: {GetGuestName}
 *      add name to {guestList}
 *      
 *      ask for number in party: {GetNumberInParty}
 *      add number to {totalGuests}
 *      
 *      ask if done: {isDone}
 *  while not {isDone}
 *  
 *  {PrintGuestList}
 *  "There are {totalGuests} total guests."
 */

using GuestBook;

ConsoleMethods.WelcomeUser();

(List<string> guestList, int totalGuests) = ConsoleMethods.GetGuests();

Console.WriteLine();
ConsoleMethods.PrintGuestList(guestList);
Console.WriteLine($"\nThe total number of guests is {totalGuests}.");