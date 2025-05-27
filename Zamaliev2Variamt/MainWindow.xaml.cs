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

namespace Zamaliev2Variamt
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Imt_Click(object sender, RoutedEventArgs e)
        {
            double rost = double.Parse(Height.Text);
            double mass = double.Parse(Mass.Text);
            if (rost <= 0)
            {
                MessageBox.Show("Введите корректно ваш рост");
            }
            else if (mass <= 0)
            {
                MessageBox.Show("Введите корректно вашу массу");
            }
            else
            {
                double imt = mass / (rost *= rost);
                MessageBox.Show("Ваш ИМТ: " + imt);
            }
        }
    }
}
