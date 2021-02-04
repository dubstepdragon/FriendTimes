using System;
using System.Collections.Generic;
using System.Text;

namespace FriendTimes.Friends.Rinn
{
    public sealed class Rinn : Friend
    {
        //need this so there's only one instance of you
        private static readonly Lazy<Rinn>
            lazy =
            new Lazy<Rinn>
                (() => new Rinn());

        public static Rinn Instance { get { return lazy.Value; } }
        


        public Rinn()
        {
            Name = "Rinn";
            emotion = EMOTION.HAPPY;
            status = STATUS.CHILL;
        }
    }

}
