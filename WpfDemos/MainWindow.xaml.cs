using Microsoft.Win32;
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
using WpfDemos.Models;

namespace WpfDemos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Person> People = new List<Person>();
            People.Add(new Person
            {
                FirstName = "Luke",
                LastName = "Skywalker",
                Age = 20
            });
            People.Add(new Person
            {
                FirstName = "Master",
                LastName = "Yoda",
                Age = 900
            });

            //People[0].FullName = String.Format("{0} {1}", People[0].FirstName, People[0].LastName);

            Person Person1 = new Person()
            {
                FirstName = "Darth",
                LastName = "Vader",
                Age = 60
            };

            //Person1.FullName = String.Format("{0} {1}", Person1.FirstName, Person1.LastName);

            Button1.DataContext = Person1;
            ComboBox1.ItemsSource = People;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GridMain.Background = Brushes.Purple;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            OpenDialog.ShowDialog();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{UserName.Text}");
            this.Close();
        }
    }
}
