using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace PROG_Draft_POE_P1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public static string modName;
    public string modCode;
    public double numCreds;
    public double numClassHrs;
    public static double numOfWeeks;
    public DateTime semDate;
    public double numSelfStudyHrs;
    public DateTime selfStudyDate;
    public String mCode;
        public double remainStudyhrs;
    public MainWindow()
    {
      InitializeComponent();
      
    }

    private void btnAddModule_Click(object sender, RoutedEventArgs e)
    {

      try
      {
        modName = tbModuleName.Text;
        modCode = tbModuleCode.Text;
        numCreds = Convert.ToDouble(tbNumberOfCredits.Text);
        numClassHrs = Convert.ToDouble(tbClassHours.Text);
        
        
        ListUtil.modules.Add(new Module { moduleName = modName, moduleCode = modCode, numberCredits = numCreds, numClassHours = numClassHrs, remainingStudyHours = Calculations.requiredStudyHrs(numCreds, numClassHrs, numOfWeeks)});
        cbModuleCode.Items.Clear(); 
        List<Module> modList = ListUtil.modules;
        foreach (Module item in modList)
        {
          cbModuleCode.Items.Add(item.moduleCode);
        }
        MessageBox.Show("Module Added!!");
                tbModuleName.Clear();
                tbModuleCode.Clear();
                tbClassHours.Clear();
                tbNumberOfCredits.Clear();
      }
      catch
      {
        MessageBox.Show("Failed to add module");
                tbModuleName.Clear();
                tbModuleCode.Clear();
                tbClassHours.Clear();
                tbNumberOfCredits.Clear();
            }


    }

    private void btnAddSemester_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Semester semester = new Semester();
                numOfWeeks = Convert.ToDouble(tbNumberOfWeeks.Text);
                semDate = Convert.ToDateTime(dpSemesterStartDate.Text);

                ListUtil.semesters.Add(new Semester { numWeeks = numOfWeeks, semesterStartDate = semDate });
                MessageBox.Show("Semester Info recorded");

                
                


            }
            catch
            {
                MessageBox.Show("Please enter the values in correctly");
                tbNumberOfWeeks.Clear();
            }
    }

    private void btnAddSelfStudyHours_Click(object sender, RoutedEventArgs e)
    {Calculations calculations = new Calculations();
            try
            {
                numSelfStudyHrs = Convert.ToDouble(tbNumberOfSelfStudyHours.Text);
                selfStudyDate = Convert.ToDateTime(dpDateOfSelfStudy.Text);
                mCode = cbModuleCode.Text;
                //LINQ used to find Module Code
                var findModule = ListUtil.modules.Find(x => x.moduleCode == mCode);

                findModule.remainingStudyHours = Calculations.SelfStudyCalc(numSelfStudyHrs, findModule.remainingStudyHours);
                MessageBox.Show("Self Study Hours Recorded");
            }
           catch
            {
                MessageBox.Show("Please enter the values in correctly");
                
                tbNumberOfSelfStudyHours.Clear();
            }
    }

    private void btnUpdateDisplay_Click(object sender, RoutedEventArgs e)
    {
           
            
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("moduleName");
            dataTable.Columns.Add("moduleCode");
            dataTable.Columns.Add("numberCredits");
            dataTable.Columns.Add("numClassHours");
            dataTable.Columns.Add("remainingStudyHours");

foreach (Module module in ListUtil.modules) 
            {
                dataTable.Rows.Add(module.moduleName, module.moduleCode, module.numberCredits, module.numClassHours, module.remainingStudyHours);
            }

            myDataGrid.ItemsSource = dataTable.DefaultView;

        }


  }
}
