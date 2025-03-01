using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_simulator.AdditionalСlass.Menu
{
    internal class LessonLevel
    {
        public static string Name(string lvl)
        {
            switch (lvl)
            {
                case "LVl1":
                    DynamicData.LessonNumber = 1;
                    return "Урок №1";
                case "LVl2":
                    DynamicData.LessonNumber = 2;
                    return "Урок №2";
                case "LVl3":
                    DynamicData.LessonNumber = 3;
                    return "Урок №3";
                case "LVl4":
                    DynamicData.LessonNumber = 4;
                    return "Урок №4";
                case "LVl5":
                    DynamicData.LessonNumber = 5;
                    return "Урок №5";
                case "LVl6":
                    DynamicData.LessonNumber = 6;
                    return "Урок №6";
                case "LVl7":
                    DynamicData.LessonNumber = 7;
                    return "Урок №7";
                case "LVl8":
                    DynamicData.LessonNumber = 8;
                    return "Урок №8";
                case "LVl9":
                    DynamicData.LessonNumber = 9;
                    return "Урок №9";
                case "LVl10":
                    DynamicData.LessonNumber = 10;
                    return "Урок №10";
                case "LVl11":
                    DynamicData.LessonNumber = 11;
                    return "Урок №11";
                case "LVl12":
                    DynamicData.LessonNumber = 12;
                    return "Урок №12";
                case "LVl13":
                    DynamicData.LessonNumber = 13;
                    return "Урок №13";
                case "LVl14":
                    DynamicData.LessonNumber = 14;
                    return "Урок №14";
                case "LVl15":
                    DynamicData.LessonNumber = 15;
                    return "Урок №15";
                case "LVl16":
                    DynamicData.LessonNumber = 16;
                    return "Урок №16";
                case "LVl17":
                    DynamicData.LessonNumber = 17;
                    return "Урок №17";
                default: return null;
            }
        }
    }
}
