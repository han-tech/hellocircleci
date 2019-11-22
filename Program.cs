using hellocirclelib;
using System;

namespace hellocircleci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CircleCI!"+ new Thing().Get(19, 23));
        }
    }
}
