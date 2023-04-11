using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime currentTime = DateTime.Now;
                Console.Write("Current time: ");

                // draw hours
                int hours = currentTime.Hour;
                string[] hourLines = GetDigitLines((char)(hours / 10 + '0'));
                Console.WriteLine(string.Join("\n", hourLines));
                hourLines = GetDigitLines((char)(hours % 10 + '0'));
                Console.WriteLine(string.Join("\n", hourLines));

                Console.Write(":");

                // draw minutes
                int minutes = currentTime.Minute;
                string[] minuteLines = GetDigitLines((char)(minutes / 10 + '0'));
                Console.WriteLine(string.Join("\n", minuteLines));
                minuteLines = GetDigitLines((char)(minutes % 10 + '0'));
                Console.WriteLine(string.Join("\n", minuteLines));

                Console.Write(":");

                // draw seconds
                int seconds = currentTime.Second;
                string[] secondLines = GetDigitLines((char)(seconds / 10 + '0'));
                Console.WriteLine(string.Join("\n", secondLines));
                secondLines = GetDigitLines((char)(seconds % 10 + '0'));
                Console.WriteLine(string.Join("\n", secondLines));

                // wait for 1 second
                System.Threading.Thread.Sleep(1000);

                // clear the console
                Console.Clear();
            }

            string[] GetDigitLines(char digit)
            {
                string[] digitLines = null;

                switch (digit)
                {
                    case '0':
                        digitLines = new string[] { " _ ", "| |", "|_|" };
                        break;
                    case '1':
                        digitLines = new string[] { "   ", "  |", "  |" };
                        break;
                    case '2':
                        digitLines = new string[] { " _ ", " _|", "|_ " };
                        break;
                    case '3':
                        digitLines = new string[] { " _ ", " _|", " _|" };
                        break;
                    case '4':
                        digitLines = new string[] { "   ", "|_|", "  |" };
                        break;
                    case '5':
                        digitLines = new string[] { " _ ", "|_ ", " _|" };
                        break;
                    case '6':
                        digitLines = new string[] { " _ ", "|_ ", "|_|" };
                        break;
                    case '7':
                        digitLines = new string[] { " _ ", "  |", "  |" };
                        break;
                    case '8':
                        digitLines = new string[] { " _ ", "|_|", "|_|" };
                        break;
                    case '9':
                        digitLines = new string[] { " _ ", "|_|", " _|" };
                        break;
                }

                return digitLines;
            }



        }
    }
}

