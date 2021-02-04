using System;
using System.Collections.Generic;
using System.Text;

namespace FriendTimes.Friends.Runi
{
    public sealed class Runi : Friend
    {
        //need this so there's only one instance of you
        private static readonly Lazy<Runi>
            lazy =
            new Lazy<Runi>
                (() => new Runi());

        public static Runi Instance { get { return lazy.Value; } }


        /// <summary>
        /// Constructor for your class
        /// </summary>
        public Runi()
        {

        }
    }
}
