using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    internal class DemoStringBuilder
    {
        public static void Demo()
        {
            var builder = new StringBuilder("Hello World"); // creates new builder

            // methods can be chained, as StringBuilder is returned
            builder
                .Append('-', 10) // append a character, times
                .AppendLine() // appends a new line
                .Append("Header") // apend a string
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+') // replaces characters
                .Remove(0, 10) // removes x amount of char
                .Insert(0, new string('-', 10)); // inserts in the StringBuilder

            Console.WriteLine(builder);

            // can use indexer to access individual char as a string
            Console.WriteLine("Firs char: " + builder[0]);
        }
    }
}
