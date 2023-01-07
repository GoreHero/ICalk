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
using System.Data;

namespace ICalk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement elem in mainGrid.Children)
            {
                if (elem is Button)
                {
                    ((Button)elem).Click += button_Click;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string btnStr = (string)((Button)e.OriginalSource).Content;

            if (btnStr == "AC")
                mainLabel.Text = "";

            else if (btnStr == "=")
            {
                string result = new DataTable().Compute(mainLabel.Text, null).ToString();
                mainLabel.Text = result;
            }
            else if (btnStr == "%")
            {
                mainLabel.Text = Convert.ToString((Convert.ToDouble(mainLabel.Text)) / (100));
            }
            else if (btnStr == "+/-")
            {
                bool flag = true;
                foreach (char i in mainLabel.Text)
                {
                    if (Convert.ToChar("-") == mainLabel.Text[0])
                        flag = true;
                    if (Convert.ToString(i) == "-" || Convert.ToString(i) == "+" || Convert.ToString(i) == "/" || Convert.ToString(i) == "*")
                    {
                        flag=false;
                    }                                           
                }
                if (flag == true)
                    mainLabel.Text = Convert.ToString((Convert.ToDouble(mainLabel.Text)) * (-1));
                else mainLabel.Text = mainLabel.Text;
            }
            else
            {
                mainLabel.Text += btnStr;
            }



        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
