using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FileIO14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserActions user = new UserActions();
            user.Menu();
            ReadLine();
        }
    }
}
