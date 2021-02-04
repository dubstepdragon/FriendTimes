using System;
using System.Collections.Generic;
using FriendTimes.Friends.Rinn;
using FriendTimes.Friends.Runi;
using FriendTimes.Friends.Legsy;
using FriendTimes.Friends;

namespace FriendTimes
{
    class main
    {
        static void Main(string[] args)
        {
            //current room of friends
            List<Friend> room1 = new List<Friend>();

            //create yourself with variable name and add to room
            Rinn rinnyboy = new Rinn();
            room1.Add(rinnyboy);

            foreach (Friend bud in room1)
            {
                Console.WriteLine($"{bud.Name} has entered the room");
                Console.WriteLine($"{bud.pronoun} is {bud.status}");
                Console.WriteLine($"{bud.pronoun} is feeling {bud.emotion}");
                Console.WriteLine($"{bud.pronoun} is {bud.action}");
            }
        }
    }
}
