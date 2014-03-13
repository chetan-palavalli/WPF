using DevExpress.Xpf.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUserControlLibrary
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            //ChartControl chartControl
            double x = 4, y = 5;
            DateTime start;
            TimeSpan time;
            start = DateTime.Now;
            //Time Analysis starts here

            for (int i = 0; i < 1000; i++)
            {
                myLineSeries.Points.Add(new SeriesPoint(x.ToString(), y));
                x += 0.005;
                y += 5;
            }
            time = DateTime.Now - start;
            String.Format("{0}.{1}", time.Seconds, time.Milliseconds.ToString().PadLeft(3, '0'));

            Console.WriteLine("Chetan 1-1000 Time Consumption is {0}", String.Format("{0}.{1}", time.Seconds, time.Milliseconds.ToString().PadLeft(3, '0')));

            DateTime start1;
            TimeSpan time1;
            start1 = DateTime.Now;
            //Time Analysis starts here
            for (int i = 0; i < 1000; i++)
            {
                myLineSeries.Points.Add(new SeriesPoint(x.ToString(), y));
                x += 0.005;
                y -= 1;
            }
            //Time Analysis ends here
            time1 = DateTime.Now - start1;
            String.Format("{0}.{1}", time1.Seconds, time1.Milliseconds.ToString().PadLeft(3, '0'));

            Console.WriteLine("Chetan 1001-2000 Time Consumption is {0}", String.Format("{0}.{1}", time1.Seconds, time1.Milliseconds.ToString().PadLeft(3, '0')));

            DateTime start2;
            TimeSpan time2;
            start2 = DateTime.Now;
            //Time Analysis starts here
            for (int i = 0; i < 1000; i++)
            {
                myLineSeries.Points.Add(new SeriesPoint(x.ToString(), y));
                x += 0.005;
                y += 1;
            }
            //Time Analysis ends here
            time2 = DateTime.Now - start2;
            String.Format("{0}.{1}", time2.Seconds, time2.Milliseconds.ToString().PadLeft(3, '0'));

            Console.WriteLine("Chetan 2001-3000 Time Consumption is {0}", String.Format("{0}.{1}", time2.Seconds, time2.Milliseconds.ToString().PadLeft(3, '0')));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a Xaml Code");
        }
    }
}
