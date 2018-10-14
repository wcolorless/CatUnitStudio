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
    public class DrawResultClass
    {
        public static void DrawResult(WrapPanel panel, List<TestResultClass> results)
        {
            panel.Children.Clear();
            for (int i = 0; i < results.Count; i++)
            {
                Grid grid = new Grid();
                if(results[i].Result == true) grid.Height = 50;
                else
                {
                    grid.Height = 80;
                    TextBlock MessageText = new TextBlock() { Text = results[i].Message, Margin = new Thickness(0, 25, 0, 0) };
                    MessageText.HorizontalAlignment = HorizontalAlignment.Center;
                    MessageText.VerticalAlignment = VerticalAlignment.Center;
                    grid.Children.Add(MessageText);
                }
                grid.Width = 570;
                grid.Margin = new Thickness(2);
                TextBlock resultText = new TextBlock { Text = results[i].Result == true ? "Тест " + results[i].TestName +   " пройден" : "Тест " + results[i].TestName + " не пройден" };
                resultText.Foreground = results[i].Result == true ? Brushes.LimeGreen : Brushes.Red;
                resultText.HorizontalAlignment = HorizontalAlignment.Center;
                resultText.VerticalAlignment = VerticalAlignment.Center;
                TextBlock numberText = new TextBlock { Text = "#"+ (i + 1).ToString() };
                numberText.HorizontalAlignment = HorizontalAlignment.Left;
                numberText.VerticalAlignment = VerticalAlignment.Top;
                numberText.Margin = new Thickness(10);
                numberText.FontSize = 18;
                Border border = new Border();
                border.BorderBrush = Brushes.Black;
                border.BorderThickness = new Thickness(1);

                grid.Children.Add(border);
                grid.Children.Add(resultText);
                grid.Children.Add(numberText);
                panel.Children.Add(grid);
            }
        }
    }
}
