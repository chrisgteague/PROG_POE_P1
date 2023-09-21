using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public double numOfWeeks;
    public DateTime semDate;
    public double numSelfStudyHrs;
    public DateTime selfStudyDate;
    public String moduleCode;
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
        ListUtil.modules.Add(new Module(modName, modCode, numCreds, numClassHrs));
        cbModuleCode.Items.Clear(); 
        List<Module> modList = ListUtil.modules;
        foreach (Module item in modList)
        {
          cbModuleCode.Items.Add(item.ModuleCode);
        }
        MessageBox.Show("Module Added!!");

      }
      catch
      {
        MessageBox.Show("Failed to add module");
      }


    }

    private void btnAddSemester_Click(object sender, RoutedEventArgs e)
    {
      Semester semester = new Semester();
      numOfWeeks = Convert.ToDouble(tbNumberOfWeeks.Text);
      semDate = Convert.ToDateTime(dpSemesterStartDate.Text);

      ListUtil.semesters.Add(new Semester { numWeeks = numOfWeeks, semesterStartDate = semDate });
    }

    private void btnAddSelfStudyHours_Click(object sender, RoutedEventArgs e)
    {
      RecordStudyHours recordStudyHours = new RecordStudyHours();
      numSelfStudyHrs = Convert.ToDouble(tbNumberOfSelfStudyHours.Text);
      selfStudyDate = Convert.ToDateTime(dpDateOfSelfStudy.Text);
      moduleCode = cbModuleCode.Text;

      ListUtil.recordStudyHours.Add(new RecordStudyHours { numStudyHours = numSelfStudyHrs, studyDate = selfStudyDate, modCode = moduleCode });
    }

    private void btnUpdateDisplay_Click(object sender, RoutedEventArgs e)
    { lvDisplay.Items.Clear();
      lvDisplay.ItemsSource = ListUtil.modules;





    }


  }
}
