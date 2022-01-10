using System;
using System.Data;
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

namespace WPF_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //добавление метода для каждой кнопки
            foreach (UIElement el in grid.Children)
            {
                if (el is Button) 
                { ((Button)el).Click += ButtonClick; }

            }
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            
            string s = (string)((Button)e.OriginalSource).Content;


            if (s == "AC")
                text.Text = "";
            else if (s == "=")
            {
                string val = new DataTable().Compute(text.Text,null).ToString();
                text.Text = val;
            }
            else
                text.Text += s; 
        }

        
    }
}
