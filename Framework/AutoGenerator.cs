using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class AutoGenerator
    {
        public static int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 15);
        }
    }
}
