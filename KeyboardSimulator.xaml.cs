using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Keyboard_simulator.AdditionalСlass;
using Keyboard_simulator.AdditionalСlass.LearningWindow;
using Path = System.IO.Path;

namespace Keyboard_simulator
{
    /// <summary>
    /// Логика взаимодействия для KeyboardSimulator.xaml
    /// </summary>
    public partial class KeyboardSimulator : Window
    {
        static int m_counterSec = 0;
        static int m_counterMin = 0;
        String[] Text;
        private Dictionary<string, Border> idBorder;
        (String item1, String item2) KeyboardData;
        public KeyboardSimulator()
        {
            InitializeComponent();
            idBorder = new Dictionary<string, Border>{ {id1.Name,id1}, { id2.Name, id2 }, { id3.Name, id3 }, { id4.Name, id4 }, { id5.Name, id5 }, { id6.Name, id6 }, { id7.Name, id7 }, { id8.Name, id8 }, { id9.Name, id9 },
            {id10.Name,id10},{id11.Name,id11},{id12.Name,id12},{id13.Name,id13},{id14.Name,id14},{id15.Name,id15},{id16.Name,id16},{ id17.Name,id17},{id18.Name,id18},{id19.Name,id19},{id20.Name,id20},
            {id21.Name,id21},{id22.Name,id22},{id23.Name,id23},{id24.Name,id24},{id25.Name,id25},{id26.Name,id26},{id27.Name,id27},{id28.Name,id28},{id29.Name,id29},{id30.Name,id30},
            {id31.Name,id31},{id32.Name,id32},{id33.Name,id33},{id34.Name,id34},{id35.Name,id35},{id36.Name,id36},{id37.Name,id37},{id38.Name,id38},{id39.Name,id39},{id40.Name,id40},
            {id41.Name,id41},{id42.Name,id42},{id43.Name,id43},{id44.Name,id44},{id45.Name,id45},{id46.Name,id46},{id47.Name,id47},{id48.Name,id48},{id49.Name,id49},{id50.Name,id50},
            {id51.Name,id51},{id52.Name,id52},{id53.Name,id53},{id54.Name,id54}};
            lessonNum.Text = "Урок №" + DynamicData.LessonNumber;
            String ProjectPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\"));
            //Text = File.ReadAllLines(ProjectPath + @"\AdditionalFiles\TextFile.txt");
            Text = DynamicData.Text;
            if (Text != null)
            {
                ItemCentre.Text = Text[0][..1];
                ItemEnd.Text = Text[0][1..];
                Text[0] = null;
            }

        }

        private void LearningWindow_KeyDown(object sender, KeyEventArgs e)
        {
            DynamicData.Systemlanguage = InputLanguageManager.Current.CurrentInputLanguage.ToString();
            if (DynamicData.Systemlanguage == "ru-RU")
                WordProcessing(KeyboardHandlerRussian.Russian(e));
            if (DynamicData.Systemlanguage == "en-US")
                KeyboardData = KeyboardHandlerEnglish.English(e);
            if (KeyboardData.item1 != null && KeyboardData.item2 != null && Text != null)
            {
                idBorder[KeyboardData.item2].Margin = new Thickness(5.5);
                WordProcessing(KeyboardData.item1);
            }
        }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            KeyboardData = KeyboardHandlerEnglish.English(e);
            if (KeyboardData.item1 != null && KeyboardData.item2 != null)
                idBorder[KeyboardData.item2].Margin = new Thickness(3);
        }
        private void WordProcessing(String item)
        {
            if (item == ItemCentre.Text && ItemEnd.Text != "")
            {
                SignsYes.Text = (int.Parse(SignsYes.Text) + 1).ToString();
                if (ItemStart.Text.Length < 20)
                {
                    ItemStart.Text += ItemCentre.Text;
                    ItemCentre.Text = ItemEnd.Text[..1];
                    ItemEnd.Text = ItemEnd.Text[1..];
                }
                else
                {
                    ItemStart.Text = ItemStart.Text[1..] + ItemCentre.Text;
                    ItemCentre.Text = ItemEnd.Text[..1];
                    ItemEnd.Text = ItemEnd.Text[1..];
                }
            }
            else if (ItemEnd.Text == "")
            {
                Trenacher.Visibility = Visibility.Collapsed;
                LastMeny.Visibility = Visibility.Visible;
                MinTime.Text = TimeMin.Text;
                secTime.Text = TimeSec.Text;
                error.Text = SignsNo.Text;
                Lessonlvlv.Text = lessonNum.Text;
                CorrectSymbols.Text = SignsYes.Text;
            }
            else
            {
                SignsNo.Text = (int.Parse(SignsNo.Text) + 1).ToString();
                if(DynamicData.Sound) SystemSounds.Asterisk.Play();
            }
            (Double x, Double y, String FilePath) HandPosition = KeyboardHandlerEnglish.HandPositionEnglish(Convert.ToChar(ItemCentre.Text));
            FingerTip.Margin = new Thickness(HandPosition.x, HandPosition.y, 0, 0);
            FingerTip.Source = BitmapFrame.Create(new Uri(@"pack://application:,,," + HandPosition.FilePath));
        }
        DispatcherTimer dt = new DispatcherTimer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt.Interval = TimeSpan.FromSeconds(2);
            dt.Tick += OnTimerElapsed;
            dt.Start();
        }
        public void OnTimerElapsed(object sender, EventArgs e)
        {
            m_counterSec++;
            if (m_counterSec < 60)
            {
                if (m_counterSec < 10)
                    TimeSec.Text = "0" + Convert.ToString(m_counterSec);
                else TimeSec.Text = Convert.ToString(m_counterSec);
            }
            else
            {
                m_counterSec = 0;
                m_counterMin++;
                if (m_counterMin < 10)
                    TimeMin.Text = "0" + Convert.ToString(m_counterMin);
                else TimeMin.Text = Convert.ToString(m_counterMin);
            }
        }

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            dt.Stop();
            Blur.Visibility = Visibility.Visible;
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Border_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            Blur.Visibility=Visibility.Collapsed;
            dt.Start();
        }
    }
}
