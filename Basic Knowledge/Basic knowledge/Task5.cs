using System.Collections.Generic;
using System.Linq;
using System;

namespace BasicKnowledge
{
    public class Task5
    {
        public static string SortGuestList(string guestList)
        {
            guestList = guestList.ToUpper();
            string[] splitted = guestList.Split(';');
            List<string> guests = new List<string>();
            foreach (var guest in splitted)
            {
                string[] guestSplitted = guest.Split(':');
                (guestSplitted[1], guestSplitted[0]) = (guestSplitted[0], guestSplitted[1]);
                guests.Add(String.Join(", ", guestSplitted));
            }
            List<string> sorted = guests.ToArray().OrderBy(guest => guest).ToList();

            string output = String.Join(")(", sorted);
            output = output.Insert(0, "(");
            output = output.Insert(output.Length, ")");

            return output;
        }
    }
}
