using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCourse.Utils
{
    public static class Translate
    {

        public static string translateToMorse(string letters)
        {
            letters.ToLower();
            string output = string.Empty;

            for (int i = 0; i < letters.Length; i++)
            {
                output += translateLetters(letters[i]);
                if (translateLetters(letters[i]) == "unknown")
                {
                    return "ERROR!";
                }
            }
            return output;
        }
        public static string translateToText(string morse)
        {
            string output = string.Empty;
            string morseWord = string.Empty;
            morse += " "; // to translate last letter
            for (int i = 0; i < morse.Length; i++)
            {
                if (morse[i] != ' ')
                {
                    morseWord += morse[i];
                }
                else
                {
                    output += translateMorse(morseWord);
                    morseWord = string.Empty;
                }

            }
            return output;
        }

        private static string translateLetters(char letter)
        {
            switch (letter)
            {
                case 'a':
                    return ".- ";
                case 'b':
                    return "-... ";
                case 'c':
                    return "-.-. ";
                case 'd':
                    return "-.. ";
                case 'e':
                    return ". ";
                case 'f':
                    return "..-. ";
                case 'g':
                    return "--. ";
                case 'h':
                    return ".... ";
                case 'i':
                    return ".. ";
                case 'j':
                    return ".--- ";
                case 'k':
                    return "-.- ";
                case 'l':
                    return ".-.. ";
                case 'm':
                    return "-- ";
                case 'n':
                    return "-. ";
                case 'o':
                    return "--- ";
                case 'p':
                    return ".--. ";
                case 'q':
                    return "--.- ";
                case 'r':
                    return ".-. ";
                case 's':
                    return "... ";
                case 't':
                    return "- ";
                case 'u':
                    return "..- ";
                case 'v':
                    return "...- ";
                case 'w':
                    return ".-- ";
                case 'x':
                    return "-..- ";
                case 'y':
                    return "-.-- ";
                case 'z':
                    return "--.. ";
                case '1':
                    return ".---- ";
                case '2':
                    return "..--- ";
                case '3':
                    return "...-- ";
                case '4':
                    return "....- ";
                case '5':
                    return "..... ";
                case '6':
                    return "-.... ";
                case '7':
                    return "--... ";
                case '8':
                    return "---.. ";
                case '9':
                    return "----. ";
                case '0':
                    return "----- ";
                case ' ':
                    return "/ ";
                default:
                    return "unknown";
            }
        }
        private static string translateMorse(string morseLetter)
        {

            switch (morseLetter)
            {
                case ".-":
                    return "a";
                case "-...":
                    return "b";
                case "-.-.":
                    return "c";
                case "-..":
                    return "d";
                case ".":
                    return "e";
                case "..-.":
                    return "f";
                case "--.":
                    return "g";
                case "....":
                    return "h";
                case "..":
                    return "i";
                case ".---":
                    return "j";
                case "-.-":
                    return "k";
                case ".-..":
                    return "l";
                case "--":
                    return "m";
                case "-.":
                    return "n";
                case "---":
                    return "o";
                case ".--.":
                    return "p";
                case "--.-":
                    return "q";
                case ".-.":
                    return "r";
                case "...":
                    return "s";
                case "-":
                    return "t";
                case "..-":
                    return "u";
                case "...-":
                    return "v";
                case ".--":
                    return "w";
                case "-..-":
                    return "x";
                case "-.--":
                    return "y";
                case "--..":
                    return "z";
                case ".----":
                    return "1";
                case "..---":
                    return "2";
                case "...--":
                    return "3";
                case "....-":
                    return "4";
                case ".....":
                    return "5";
                case "-....":
                    return "6";
                case "--...":
                    return "7";
                case "---..":
                    return "8";
                case "----.":
                    return "9";
                case "-----":
                    return "0";
                case "/":
                    return " ";
                case "":
                    return "";
                default:
                    return "unknown";
            }
        }
    }
}
