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
using System.IO;

namespace CatUnitStudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestFileClass testfile;
        List<TestResultClass> TestResult;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void close_btn(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void exec_btn(object sender, RoutedEventArgs e)
        {
            testfile = OpenTestFileClass.OpenTest(); // Открываем файл с тестами
            if(testfile != null)
            {
                string all_lines = File.ReadAllText(testfile.PathToFile); // Считываем исходный код
                string prepare_text = PrepareTextClass.PrepareText(all_lines); // Очищаем текст от посторонних символов
                List<string> funcNames = FindFuncNameClass.Find(prepare_text, 0);
                TestCycleClass TestCycle = new TestCycleClass(testfile, funcNames);
                TestResult = await TestCycle.RunTest();
                DrawResultClass.DrawResult(panel, TestResult);
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private  void SaveResultBtn(object sender, RoutedEventArgs e)
        {
            SaveResultClass.SaveResultTxt(TestResult, testfile.FileName);
        }
    }
}
