using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._3
{
    public class Accauntant
    {
        public enum Post
        {
            jun = 40,
            midl =  35,
            sin = 30
        }

        public static bool AskForBonus(Post worker, int hours)
        {
            bool result;
            if (hours > (int)worker)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
