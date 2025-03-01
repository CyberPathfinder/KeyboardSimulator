using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Keyboard_simulator.AdditionalСlass
{
    struct DynamicData
    {
        public static String Systemlanguage;
        public static Int32 NumberOfCharacters = 0;
        public static String[] Text = new string[1];
        public static int LessonNumber;
        public static Boolean ShowPicture = true;
        public static Boolean Stage3 = false;
        public static string Time;
        public static bool Sound = true;
        public static WindowState windowState;
    }
}
