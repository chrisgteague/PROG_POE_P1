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

namespace PROG_Draft_POE_P1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        { Calculations calculations = new Calculations();
            int classHrs = Convert.ToInt32(tbClassHours.Text);
            int numCredits = Convert.ToInt32(tbNumberOfCredits.Text);
            int numberOfWeeks = Convert.ToInt32(tbNumberOfWeeks.Text);

            //tbTestAnswer.Text = calculations.SelfStudyCalc(numCredits, numberOfWeeks, classHrs);

        }
    }
}
