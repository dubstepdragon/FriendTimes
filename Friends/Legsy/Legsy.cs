using System;
using System.Collections.Generic;
using System.Text;

namespace FriendTimes.Friends.Legsy
{
    public sealed class Legsy : Friend
    {
        //need this so there's only one instance of you
        private static readonly Lazy<Legsy>
            lazy =
            new Lazy<Legsy>
                (() => new Legsy());

        public static Legsy Instance { get { return lazy.Value; } }


        /// <summary>
        /// Constructor for your class
        /// </summary>
        public Legsy()
        {
  
        }

        
    }
}
