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
        public static string modName;
        public string modCode;
        public int numCreds;
        public int numClassHrs;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddModule_Click(object sender, RoutedEventArgs e)
        {
            modName = tbModuleName.Text;
            modCode = tbModuleCode.Text;
            numCreds = Convert.ToInt32(tbNumberOfCredits.Text);
            numClassHrs = Convert.ToInt32(tbClassHours);

            ListUtil.modules.Add(new Module { moduleName = modName, moduleCode = modCode, numberCredits = numCreds, numClassHours = numClassHrs });

        }
    }
}
