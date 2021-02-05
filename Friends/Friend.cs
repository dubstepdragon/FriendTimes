using System;
using System.Collections.Generic;
using System.Text;

namespace FriendTimes.Friends
{

    /// <summary>
    /// In your own personal class ensure you give a name and change any emotions you want. expand on any functions too. 
    /// 
    /// Friends currently have a:
    /// 
    /// status
    /// emotion
    /// action
    /// pronoun
    /// 
    /// </summary>
    public class Friend
    {
        public string Name = "";
        /// <summary>
        /// Add to these, keep these to things you can be 
        /// NEUTRAL IS DEFAULT
        /// </summary>
        public enum STATUS
        {
            NEUTRAL,
            SLEEPY,
            HUNGRY,
            COLD,
            HOT,
            CHILL,
            IRKED,

        }
        public STATUS status = STATUS.NEUTRAL;

        /// <summary>
        /// Add to these, keep these to things you can feel
        /// NEUTRAL IS DEFAULT
        /// </summary>
        public enum EMOTION
        {
            NEUTRAL, 
            HAPPY,
            EXCITED,
            SAD,
            SCARED,
            DISGUST,
            SURPRISED,
            TRUSTING,
            CONTENT,
            MISERABLE,
        }
        public EMOTION emotion = EMOTION.NEUTRAL;

        /// <summary>
        /// Add to these, keep these to things you can do
        /// NOTHING IS DEFAULT
        /// </summary>
        public enum ACTION
        {
            NOTHING,
            DANCY, 
            JUMPING,
            HUGGING,
            CHILLING
        }
        public ACTION action = ACTION.NOTHING;

        /// <summary>
        /// Add to these? idk why you would want to
        /// </summary>
        public enum PRONOUN
        {
            HE,
            SHE
        }
        public PRONOUN pronoun = PRONOUN.HE;


        //BASE CLASS FUNCTIONS THAT EVERYONE SHOULD HAVE
        

        /// <summary>
        /// Expand on this if necessary, perhaps return fale state if hug not accepted?
        /// </summary>
        /// <param name="target"></param>
        public bool Hug(Friend target)
        {
            this.action = ACTION.HUGGING;
            target.action = ACTION.HUGGING;
            return true;
        }
    }
}
