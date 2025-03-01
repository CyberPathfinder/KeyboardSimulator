using System;
using System.Windows.Input;

namespace Keyboard_simulator.AdditionalСlass.LearningWindow
{
    internal class KeyboardHandlerEnglish
    {
        public static (string, string) English(KeyEventArgs e)
        {

            switch (e.Key)
            {
                case Key.Enter:
                    return ("\n", "id41");
                case Key.Space:
                    return ("⠀", "id54");
                case Key.D0:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return (")", "id11");
                    return ("0", "id11");
                case Key.D1:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("!", "id2");
                    return ("1", "id2");
                case Key.D2:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("@", "id3");
                    return ("2", "id3");
                case Key.D3:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("#", "id4");
                    return ("3", "id4");
                case Key.D4:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("$", "id5");
                    return ("4", "id5");
                case Key.D5:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("%", "id6");
                    return ("5", "id6");
                case Key.D6:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("^", "id7");
                    return ("6", "id7");
                case Key.D7:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("&", "id8");
                    return ("7", "id8");
                case Key.D8:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("*", "id9");
                    return ("8", "id9");
                case Key.D9:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("(", "id10");
                    return ("9", "id10");
                case Key.OemMinus:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("_", "id12");
                    return ("-", "id12");
                case Key.OemPlus:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("+", "id13");
                    return ("=", "id13");
                case Key.A:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("a", "id30");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("A", "id30");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("A", "id30");
                    return ("a", "id30");
                case Key.B:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("b", "id47");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("B", "id47");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("B", "id47");
                    return ("b", "id47");
                case Key.C:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("c", "id45");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("C", "id45");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("C", "id45");
                    return ("c", "id45");
                case Key.D:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("d", "id32");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("D", "id32");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("D", "id32");
                    return ("d", "id32");
                case Key.E:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("e", "id18");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("E", "id18");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("E", "id18");
                    return ("e", "id18");
                case Key.F:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("f", "id33");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("F", "id33");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("F", "id33");
                    return ("f", "id33");
                case Key.G:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("g", "id34");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("G", "id34");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("G", "id34");
                    return ("g", "id34");
                case Key.H:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("h", "id35");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("H", "id35");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("H", "id35");
                    return ("h", "id35");
                case Key.I:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("i", "id23");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("I", "id23");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("I", "id23");
                    return ("i", "id23");
                case Key.J:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("j", "id36");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("J", "id36");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("J", "id36");
                    return ("j", "id36");
                case Key.K:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("k", "id37");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("K", "id37");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("K", "id37");
                    return ("k", "id37");
                case Key.L:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("l", "id38");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("L", "id38");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("L", "id38");
                    return ("l", "id38");
                case Key.M:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("m", "id49");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("M", "id49");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("M", "id49");
                    return ("m", "id49");
                case Key.N:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("n", "id48");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("N", "id48");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("N", "id48");
                    return ("n", "id48");
                case Key.O:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("o", "id24");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("O", "id24");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("O", "id24");
                    return ("o", "id24");
                case Key.P:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("p", "id25");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("P", "id25");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("P", "id25");
                    return ("p", "id25");
                case Key.Q:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("q", "id16");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("Q", "id16");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("Q", "id16");
                    return ("q", "id16");
                case Key.R:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("r", "id19");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("R", "id19");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("R", "id19");
                    return ("r", "id19");
                case Key.S:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("s", "id31");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("S", "id31");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("S", "id31");
                    return ("s", "id31");
                case Key.T:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("t", "id20");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("T", "id20");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("T", "id20");
                    return ("t", "id20");
                case Key.U:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("u", "id22");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("U", "id22");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("U", "id22");
                    return ("u", "id22");
                case Key.V:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("v", "id46");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("V", "id46");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("V", "id46");
                    return ("v", "id46");
                case Key.W:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("w", "id17");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("W", "id17");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("W", "id17");
                    return ("w", "id17");
                case Key.X:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("x", "id44");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("X", "id44");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("X", "id44");
                    return ("x", "id44");
                case Key.Y:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("y", "id21");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("Y", "id21");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("Y", "id21");
                    return ("y", "id21");
                case Key.Z:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return ("z", "id43");
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return ("Z", "id43");
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("Z", "id43");
                    return ("z", "id43");
                case Key.OemComma:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("<", "id50");
                    return (",", "id50");
                case Key.OemPeriod:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return (">", "id51");
                    return (".", "id51");
                case Key.Oem2:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("?", "id52");
                    return ("/", "id52");
                case Key.Oem4:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("{", "id26");
                    return ("[", "id26");
                case Key.Oem6:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("}", "id27");
                    return ("]", "id27");
                case Key.Oem1:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return (":", "id39");
                    return (";", "id39");
                case Key.Oem7:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("\"", "id40");
                    return ("'", "id40");
                case Key.Oem5:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ("\\", "id28");
                    return ("|", "id28");
                case Key.NumPad0:
                    return ("0", "id11");
                case Key.NumPad1:
                    return ("1", "id2");
                case Key.NumPad2:
                    return ("2", "id3");
                case Key.NumPad3:
                    return ("3", "id4");
                case Key.NumPad4:
                    return ("4", "id5");
                case Key.NumPad5:
                    return ("5", "id6");
                case Key.NumPad6:
                    return ("6", "id7");
                case Key.NumPad7:
                    return ("7", "id8");
                case Key.NumPad8:
                    return ("8", "id9");
                case Key.NumPad9:
                    return ("9", "id10");
                default:
                    return (null, null);
            }
        }
        public static (Double x, Double y, String FilePath) HandPositionEnglish(Char item)
        {
            item = char.ToLower(item);
            switch (item)
            {
                //Левая рука
                case '`':
                case '~':
                    return (41, 10, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftLittleFinger.png");
                case 'q':
                    return (139, 84, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftLittleFinger.png");
                case 'a':
                    return (161, 140, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftLittleFinger.png");

                case '1':
                case '!':
                    return (98, 30, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
                case '2':
                case '@':
                    return (166, 33, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
                case 'w':
                    return (186, 100, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
                case 's':
                    return (220, 162, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
                case 'z':
                    return (182, 226, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");

                case '3':
                case '#':
                    return (205, 35, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
                case '4':
                case '$':
                    return (276, 35, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
                case 'e':
                    return (226, 100, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
                case 'd':
                    return (256, 161, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
                case 'x':
                    return (220, 222, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");

                case '5':
                case '%':
                    return (324, 32, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case '6':
                case '^':
                    return (396, 32, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case 'r':
                    return (271, 90, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case 't':
                    return (340, 90, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case 'f':
                    return (300, 160, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case 'g':
                    return (369, 160, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case 'c':
                    return (267, 221, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case 'v':
                    return (333, 221, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
                case 'b':
                    return (407, 221, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");

                case '⠀':
                    return (334, 210, @"/Images/SimulatorMenu/Keyboard/LeftHand/LeftThumb.png");
                //Правая рука
                case '7':
                case '&':
                    return (502, 29, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
                case '8':
                case '*':
                    return (572, 29, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
                case 'y':
                    return (452, 89, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
                case 'u':
                    return (521, 89, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
                case 'h':
                    return (483, 161, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
                case 'j':
                    return (556, 161, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
                case 'n':
                    return (521, 224, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
                case 'm':
                    return (585, 224, @"/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");

                case '9':
                case '(':
                    return (615, 33, @"/Images/SimulatorMenu/Keyboard/RightHand/RightMiddleFinger.png");
                case 'i':
                    return (567, 100, @"/Images/SimulatorMenu/Keyboard/RightHand/RightMiddleFinger.png");
                case 'k':
                    return (597, 162, @"/Images/SimulatorMenu/Keyboard/RightHand/RightMiddleFinger.png");
                case '<':
                case ',':
                    return (631, 222, @"/Images/SimulatorMenu/Keyboard/RightHand/RightMiddleFinger.png");

                case '0':
                case ')':
                    return (660, 34, @"/Images/SimulatorMenu/Keyboard/RightHand/RightRingFinger.png");
                case 'o':
                    return (609, 100, @"/Images/SimulatorMenu/Keyboard/RightHand/RightRingFinger.png");
                case 'l':
                    return (636, 160, @"/Images/SimulatorMenu/Keyboard/RightHand/RightRingFinger.png");
                case '.':
                case '>':
                    return (673, 217, @"/Images/SimulatorMenu/Keyboard/RightHand/RightRingFinger.png");

                case '-':
                case '_':
                    return (702, 10, "/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case '+':
                case '=':
                    return (780, 10, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case 'p':
                    return (650, 84, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case '{':
                case '[':
                    return (723, 84, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case ']':
                case '}':
                    return (791, 84, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case '\\':
                case '|':
                    return (861, 85, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case ';':
                case ':':
                    return (683, 150, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case '"':
                case '\'':
                    return (751, 150, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case '\n':
                case '¶':
                    return (831, 150, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                case '?':
                case '/':
                    return (719, 207, @"/Images/SimulatorMenu/Keyboard/RightHand/RightLittleFinger.png");
                default:
                    return (0, 0, null);
            }
        }
    }
}
