using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true)
            {
                // získat čas
                DateTime now = DateTime.Now;

                
                string hours = now.Hour.ToString("00");
                string minutes = now.Minute.ToString("00");
                string seconds = now.Second.ToString("00");

               
                string time = hours + ":" + minutes + ":" + seconds;

                // čistá konzole
                Console.Clear();

                
                DrawDigits(0, 0, time);

                
                Thread.Sleep(1000);
            }
        }

        static void DrawDigits(int x, int y, string digits)
        {
            // šířka čísel tabulka
            Dictionary<char, int> digitWidths = new Dictionary<char, int>()
    {
        { '0', 3 },
        { '1', 2 },
        { '2', 3 },
        { '3', 3 },
        { '4', 3 },
        { '5', 3 },
        { '6', 3 },
        { '7', 3 },
        { '8', 3 },
        { '9', 3 },
        { ':', 1 }};

            //kreslení čísel
            string[][] digitLines = new string[digits.Length][];
            for (int i = 0; i < digits.Length; i++)
            {
                char digit = digits[i];
                switch (digit)
                {
                    case '0':
                        digitLines[i] = new string[] { " _ ", "| |", "|_|" };
                        break;
                    case '1':
                        digitLines[i] = new string[] { "   ", "  |", "  |" };
                        break;
                    case '2':
                        digitLines[i] = new string[] { " _ ", " _|", "|_ " };
                        break;
                    case '3':
                        digitLines[i] = new string[] { " _ ", " _|", " _|" };
                        break;
                    case '4':
                        digitLines[i] = new string[] { "   ", "|_|", "  |" };
                        break;
                    case '5':
                        digitLines[i] = new string[] { " _ ", "|_ ", " _|" };
                        break;
                    case '6':
                        digitLines[i] = new string[] { " _ ", "|_ ", "|_|" };
                        break;
                    case '7':
                        digitLines[i] = new string[] { " _ ", "  |", "  |" };
                        break;
                    case '8':
                        digitLines[i] = new string[] { " _ ", "|_|", "|_|" };
                        break;
                    case '9':
                        digitLines[i] = new string[] { " _ ", "|_|", " _|" };
                        break;
                    case ':':
                        digitLines[i] = new string[] { "   ", " . ", " . " };
                        break;
                }
            }
            //nastavení kuroru podle šířky
            for (int line = 0; line < 3; line++)
            {
                int digitX = x;
                for (int i = 0; i < digits.Length; i++)
                {
                    Console.SetCursorPosition(digitX, y + line);
                    Console.Write(digitLines[i][line]);
                    digitX += digitWidths[digits[i]] + 1;
                }
            }
        }
    }
}
