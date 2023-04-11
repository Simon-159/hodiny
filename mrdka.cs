using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Console.CursorVisible = false;

                while (true)
                {
                    // Get current time
                    DateTime currentTime = DateTime.Now;

                    // Format time string as "hh:mm:ss"
                    string timeString = currentTime.ToString("hh:mm:ss");

                    // Draw hours
                    int x = 0;
                    int y = 0;
                    DrawDigit(timeString[0], x, y);

                    // Draw colon between hours and minutes
                    x += 4;
                    DrawColon(x, y);

                    // Draw minutes
                    x += 4;
                    DrawDigit(timeString[1], x, y);

                    // Draw colon between minutes and seconds
                    x += 4;
                    DrawColon(x, y);

                    // Draw seconds
                    x += 4;
                    DrawDigit(timeString[3], x, y);
                    x += 4;
                    DrawDigit(timeString[4], x, y);
                    x += 4;
                    DrawDigit(timeString[6], x, y);

                    // Wait for one second
                    System.Threading.Thread.Sleep(1000);

                    // Clear console
                    Console.Clear();
                }
            }

            static void DrawDigit(char digit, int x, int y)
            {
                string[] digitLines = GetDigitLines(digit);

                for (int i = 0; i < digitLines.Length; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(digitLines[i]);
                }
            }

            static void DrawColon(int x, int y)
            {
                string[] colonLines = GetColonLines();

                for (int i = 0; i < colonLines.Length; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.Write(colonLines[i]);
                }
            }
        static string[] GetDigitLines(char digit)
        {
            string[] digitLines = null;

            switch (digit)
            {
                case '0':
                    digitLines = new string[]
                    {
                " #### ",
                "|    |",
                "|    |",
                "|    |",
                "|    |",
                "|    |",
                " #### "
                    };
                    break;
                case '1':
                    digitLines = new string[]
                    {
                "  ||  ",
                " |||  ",
                "  ||#  ",
                "  ||  ",
                "  ||  ",
                "  ||  ",
                "||||||"
                    };
                    break;
                case '2':
                    digitLines = new string[]
                    {
                 " #### ",
                "|    |",
                "     |",
                " #### ",
                "|     ",
                "|     ",
                " #### "
                    };
                    break;
                case '3':
                    digitLines = new string[]
                    {
                " #### ",
                "|    |",
                "     |",
                " #### ",
                "     |",
                "|    |",
                " #### "
                    };
                    break;
                case '4':
                    digitLines = new string[]
                    {
                "|   | ",
                "|   | ",
                "|   | ",
                " ---- ",
                "    | ",
                "    | ",
                "    | "
                    };
                    break;
                case '5':
                    digitLines = new string[]
                    {
                "####### ",
                "##      ",
                "##      ",
                " ###### ",
                "     ## ",
                "##    ##",
                " ###### "
                    };
                    break;
                case '6':
                    digitLines = new string[]
                    {
                " #### ",
                "|     ",
                "|     ",
                " #### ",
                "|    |",
                "|    |",
                " #### "
                    };
                    break;
                case '7':
                    digitLines = new string[]
                    {
               " #####",
                "     |",
                "     |",
                "     |",
                "     |",
                "     |",
                "     |"
                    };
                    break;
                case '8':
                    digitLines = new string[]
                    {
                " #### ",
                "|    |",
                "|    |",
                " #### ",
                "|    |",
                "|    |",
                " #### "
                    };
                    break;
                case '9':
                    string[] strings = new string[]
                                        {
                 " #### ",
                "|    |",
                "|    |",
                " ####|",
                "     |",
                "     |",
                " #### "
                                        };
                    digitLines = strings;
                    break;
            }

            return digitLines;
        }

        static string[] GetColonLines()
        {
            return new string[]
            {
        "    ",
        " ## ",
        "    ",
        " ## ",
        "    "
            };
        }




    }
}
