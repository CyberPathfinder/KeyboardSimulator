using Keyboard_simulator.AdditionalСlass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Simulator
{
    public class Text_Output
    {
        public void TextGeneration()
        {
            Random rnd = new Random();
            int WordLength;
            int byf;
            DynamicData.Text = new string[1];
            switch (DynamicData.LessonNumber)
            {
                case 1:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(1, 6);
                            if (byf <= 3)
                                DynamicData.Text[0] += "f";
                            else
                                DynamicData.Text[0] += "j";
                        }   
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 2:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(1, 5);
                            if (byf <= 2)
                                DynamicData.Text[0] += "d";
                            else if (byf >= 2 && byf < 5)
                                DynamicData.Text[0] += "f";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 3:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(1, 5);
                            if (byf <= 2)
                                DynamicData.Text[0] += "s";
                            else if (byf >= 2 && byf < 5)
                                DynamicData.Text[0] += "l";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 4:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3); ;
                            if (byf == 1)
                                DynamicData.Text[0] += "a";
                            else if (byf == 2)
                                DynamicData.Text[0] += ";";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 5:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3); ;
                            if (byf == 1)
                                DynamicData.Text[0] += "g";
                            else if (byf == 2)
                                DynamicData.Text[0] += "h";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 6:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "t";
                            else if (byf == 2)
                                DynamicData.Text[0] += "y";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 7:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "r";
                            else if (byf == 2)
                                DynamicData.Text[0] += "u";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 8:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 2)
                                DynamicData.Text[0] += "e";
                            else if (byf == 1)
                                DynamicData.Text[0] += "i";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 9:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "b";
                            else if (byf == 2)
                                DynamicData.Text[0] += "n";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u', 'e', 'i' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 10:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "v";
                            else if (byf == 2)
                                DynamicData.Text[0] += "m";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u', 'e', 'i', 'b', 'n' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 11:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "c";
                            else if (byf == 2)
                                DynamicData.Text[0] += ",";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u', 'e', 'i', 'b', 'n', 'v', 'm' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 12:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "w";
                            else if (byf == 2)
                                DynamicData.Text[0] += "o";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u', 'e', 'i', 'b', 'n', 'v', 'm', 'c', ',' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 13:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "q";
                            else if (byf == 1)
                                DynamicData.Text[0] += "p";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u', 'e', 'i', 'b', 'n', 'v', 'm', 'w', 'o' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 14:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "x";
                            else if (byf == 2)
                                DynamicData.Text[0] += ".";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u', 'e', 'i', 'b', 'n', 'v', 'm', 'w', 'o', 'q', 'p' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                case 15:
                    while (DynamicData.NumberOfCharacters > 0)
                    {
                        WordLength = rnd.Next(4, 8);
                        DynamicData.NumberOfCharacters -= WordLength;
                        for (int i = 0; i < WordLength; i++)
                        {
                            byf = rnd.Next(3);
                            if (byf == 1)
                                DynamicData.Text[0] += "z";
                            else if (byf == 2)
                                DynamicData.Text[0] += "/";
                            else
                                DynamicData.Text[0] += RandomLetter(new char[] { 'f', 'j', 'd', 'k', 's', 'l', 'a', ';', 'g', 'h', 't', 'y', 'r', 'u', 'e', 'i', 'b', 'n', 'v', 'm', 'w', 'o', 'q', 'p', 'x', '.' });
                        }
                        DynamicData.Text[0] += "⠀";
                    }
                    break;
                default:
                    break;
            }
        }
        private char RandomLetter(Char[] items)
        {
            Random rnd = new Random();
            int Number = rnd.Next(0, items.Length);
            return items[Number];
        }
    }
}
