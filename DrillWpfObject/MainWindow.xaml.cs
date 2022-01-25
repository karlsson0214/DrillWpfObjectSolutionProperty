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

namespace DrillWpfObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Result> results = new List<Result>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int distance = Convert.ToInt32(Distance.Text);
            double time = Convert.ToDouble(Time.Text);

            Result result = new Result(distance, NameOfRunner.Text, time);

            Distance.Text = "";
            NameOfRunner.Text = "";
            Time.Text = "";

            results.Add(result);

            listOfResults.Text = "";

            foreach(Result oneResult in results)
            {
                listOfResults.Text += oneResult.Name + Environment.NewLine;
                listOfResults.Text += "Distance: " + oneResult.Distance 
                    + " m" + Environment.NewLine;
                listOfResults.Text += "Time: " + oneResult.Time + " s"
                    + Environment.NewLine + Environment.NewLine;
            }

            
        }
    }
}
