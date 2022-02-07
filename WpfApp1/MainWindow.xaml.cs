using System.Windows;
using System.Windows.Navigation;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class helper
        {
            public static WSR012Entities ent;

            public static int priority = 0;
            public static bool flag = false;

            public static WSR012Entities GetContext()
            {
            if (ent == null)
                {
                    ent = new WSR012Entities();
                }
            return ent;
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            frame.Content = new Page1(frame);
        }

        private void frame_LoadCompleted(object sender, NavigationEventArgs e)
        {
            try
            {
                Page1 pg = (Page1)e.Content;
                pg.Load();
            }
            catch { };
        }
    }
}
