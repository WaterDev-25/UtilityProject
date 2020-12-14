using System;

namespace UtilityProject
{
    public class Mono
    {
        // No need to call to use the function

        public static void print(string args)
        {
            Print.print(args);
        }
        public static void println(string args)
        {
            PrintIn.printIn(args);
        }
        public static void delay(int args)
        {
            Delay.delay(args);
        }
    }
}
