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

namespace WPFlabOOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "Art";
            emp1.LastName = "dvp";
            emp1.Position = "CTO";

            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Art1";
            emp2.LastName = "dvp2";
            emp2.Position = "Chief";

            Employee emp3 = new Employee();
            emp3.Id = 3;
            emp3.Name = "Art3";
            emp3.LastName = "dvp3";
            emp3.Position = "GG";

            List<Employee> ListEmp = new List<Employee>();
            ListEmp.Add(emp1);
            ListEmp.Add(emp2);
            ListEmp.Add(emp3);

            foreach (Employee obj in ListEmp)
            {
                if (obj.Id == Int32.Parse(employeeTextBox.Text))
                {
                    MessageBox.Show("id : " + obj.Id + " Name : " + obj.Name + " LastName : " + obj.LastName + " Position : " + obj.Position);
                    break;
                }
            }
        }
    }
}
