using System;

namespace RunShellCmd
{
    class Program
    {
        static void Main(string[] args)
        {
             var output = "cat /etc/os-release".Bash();
            Console.WriteLine(output);
        }
    }
}
