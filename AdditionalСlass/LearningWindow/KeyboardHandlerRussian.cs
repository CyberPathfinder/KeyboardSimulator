using System.Windows.Input;

namespace Keyboard_simulator.AdditionalСlass.LearningWindow
{
    internal class KeyboardHandlerRussian
    {
        public static string Russian(KeyEventArgs e)
        {

            switch (e.Key)
            {
                case Key.Enter:
                    return "\n";
                case Key.Space:
                    return " ";
                case Key.D0:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ")";
                    return "0";
                case Key.D1:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "!";
                    return "1";
                case Key.D2:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "\"";
                    return "2";
                case Key.D3:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "№";
                    return "3";
                case Key.D4:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ";";
                    return "4";
                case Key.D5:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "%";
                    return "5";
                case Key.D6:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ":";
                    return "6";
                case Key.D7:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "?";
                    return "7";
                case Key.D8:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "*";
                    return "8";
                case Key.D9:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "(";
                    return "9";
                case Key.A:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ф";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ф";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ф";
                    return "ф";
                case Key.B:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "и";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "И";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "И";
                    return "и";
                case Key.C:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "с";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "С";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "С";
                    return "с";
                case Key.D:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "в";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "В";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "В";
                    return "в";
                case Key.E:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "у";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "У";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "У";
                    return "у";
                case Key.F:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "а";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "А";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "А";
                    return "а";
                case Key.G:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "п";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "П";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "П";
                    return "п";
                case Key.H:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "р";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Р";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Р";
                    return "р";
                case Key.I:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ш";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ш";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ш";
                    return "ш";
                case Key.J:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "о";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "О";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "О";
                    return "о";
                case Key.K:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "л";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Л";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Л";
                    return "л";
                case Key.L:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "д";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Д";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Д";
                    return "д";
                case Key.M:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ь";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ь";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ь";
                    return "ь";
                case Key.N:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "т";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Т";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Т";
                    return "т";
                case Key.O:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "щ";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Щ";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Щ";
                    return "щ";
                case Key.P:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "з";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "З";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "З";
                    return "з";
                case Key.Q:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "й";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Й";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Й";
                    return "й";
                case Key.R:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "к";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "К";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "К";
                    return "к";
                case Key.S:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ы";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ы";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ы";
                    return "ы";
                case Key.T:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "е";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Е";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Е";
                    return "е";
                case Key.U:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "г";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Г";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Г";
                    return "г";
                case Key.V:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "м";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "М";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "М";
                    return "м";
                case Key.W:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ц";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ц";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ц";
                    return "ц";
                case Key.X:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ч";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ч";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ч";
                    return "ч";
                case Key.Y:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "н";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Н";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Н";
                    return "н";
                case Key.Z:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "я";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Я";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Я";
                    return "я";
                case Key.OemComma:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "б";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Б";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Б";
                    return "б";
                case Key.OemPeriod:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ю";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ю";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ю";
                    return "ю";
                case Key.Oem2:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return ",";
                    return ".";
                case Key.Oem4:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "х";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Х";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Х";
                    return "х";
                case Key.Oem6:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ъ";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ъ";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ъ";
                    return "ъ";
                case Key.Oem1:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "ж";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Ж";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Ж";
                    return "ж";
                case Key.Oem7:
                    if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                    {
                        if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            return "э";
                        else if (e.KeyboardDevice.IsKeyToggled(Key.CapsLock))
                            return "Э";
                    }
                    else if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "Э";
                    return "э";
                case Key.Oem5:
                    if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                        return "\\";
                    return "/";
                case Key.NumPad0:
                    return "0";
                case Key.NumPad1:
                    return "1";
                case Key.NumPad2:
                    return "2";
                case Key.NumPad3:
                    return "3";
                case Key.NumPad4:
                    return "4";
                case Key.NumPad5:
                    return "5";
                case Key.NumPad6:
                    return "6";
                case Key.NumPad7:
                    return "7";
                case Key.NumPad8:
                    return "8";
                case Key.NumPad9:
                    return "9";
                default:
                    return "";
            }
        }
        //public static (Double x, Double y, String FilePath) HandPositionRussian(Char item)
        //{
        //    item = char.ToLower(item);
        //    switch (item)
        //    {
        //        //Левая рука
        //        case 'ё':
        //            return (41, 10, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftLittleFinger.png");
        //        case 'й':
        //            return (131, 0, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftLittleFinger.png");
        //        case 'ф':
        //            return (161, 140, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftLittleFinger.png");

        //        case '1':
        //        case '!':
        //            return (98, 30, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
        //        case '2':
        //        case '"':
        //            return (166, 33, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
        //        case 'ц':
        //            return (186, 100, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
        //        case 'ы':
        //            return (220, 162, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");
        //        case 'я':
        //            return (182, 226, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftRingFinger.png");

        //        case '3':
        //        case '№':
        //            return (205, 35, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
        //        case '4':
        //        case ';':
        //            return (276, 35, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
        //        case 'у':
        //            return (226, 100, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
        //        case 'в':
        //            return (256, 161, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");
        //        case 'ч':
        //            return (220, 222, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftMiddleFinger.png");

        //        case '5':
        //        case '%':
        //            return (324, 32, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case '6':
        //        case ':':
        //            return (396, 32, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case 'к':
        //            return (271, 90, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case 'е':
        //            return (340, 90, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case 'а':
        //            return (300, 160, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case 'п':
        //            return (369, 160, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case 'с':
        //            return (267, 221, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case 'м':
        //            return (333, 221, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");
        //        case 'и':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftIndexFinger.png");

        //        case ' ':
        //            return (334, 210, "/Images/SimulatorMenu/Keyboard/LeftHand/LeftThumb.png");
        //        //Правая рука
        //        case '7':
        //        case '?':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        case '8':
        //        case '*':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        case '?':
        //        case '&':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        case '?':
        //        case '&':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        case '?':
        //        case '&':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        case '?':
        //        case '&':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        case '?':
        //        case '&':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        case '?':
        //        case '&':
        //            return (407, 221, "/Images/SimulatorMenu/Keyboard/RightHand/RightIndexFinger.png");
        //        default:
        //            break;
        //    }
        //}
    }
}
