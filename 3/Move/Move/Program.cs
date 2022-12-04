using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Move
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"E:\tit\Tasks\Quiz 1\Move\MoveTest\A\test1.txt";
            string destinationFile = @"E:\tit\Tasks\Quiz 1\Move\MoveTest\B\test1.txt";

            // // // To move a file or folder to a new location:
            File.Move(sourceFile, destinationFile);

           // To move an entire directory.To programmatically modify or combine
           //path strings, use the System.IO.Path class.
          Directory.Move(@"E:\tit\Tasks\Quiz 1\Move\MoveTest\x\", @"E:\tit\Tasks\Quiz 1\Move\MoveTest\y");
            Console.ReadKey();

        }
    }
}
