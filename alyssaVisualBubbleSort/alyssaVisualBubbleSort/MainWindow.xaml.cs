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

namespace alyssaVisualBubbleSort
{
    public partial class MainWindow : Window
    {
        int[] numbers = { 90, 67, 174, 45, 89, 7};
        Rectangle[] rect;
        public MainWindow()
        {
            InitializeComponent();



            int largest = numbers[0];
            for (int a = 0; a < numbers.Length; a++)
            {
                if(largest < numbers[a])
                {
                    largest = numbers[a];
                }
            }


            rect = new Rectangle[]{ rect1, rect2, rect3, rect4, rect5, rect6 };

            for(int z = 0; z < numbers.Length; z++)
            {
                rect[z].Width = ((double)numbers[z] / largest) * 150;
            }




        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {

            bool switched;
            do
            {
                switched = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        double temp = rect[i].Width;
                        rect[i].Width = rect[i + 1].Width;
                        rect[i + 1].Width = temp;
                        int tempnum = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = tempnum;

                        switched = true;
                    }
                }
            } while (switched);

        }
    }
}
