using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoStuff.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stuffDoer = new StuffDoer();
            if (args != null && args.Length > 0)
            {
                stuffDoer.DoTheStuff();
            }
        }
    }
}
