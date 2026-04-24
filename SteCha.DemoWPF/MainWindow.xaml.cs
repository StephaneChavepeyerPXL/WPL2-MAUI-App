using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SteCvp.Application.Framework;
using SteCvp.Application.Services;
using SteCvp.Domain;

namespace SteCha.DemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        public MainWindow()
        {

            InitializeComponent();

            StudentService studentService = new StudentService();

            SelectResult<Student> selectResult = studentService.GetStudents();

            if (selectResult.Errors.Count > 0)

            {

                foreach (string error in selectResult.Errors)

                {

                    MessageBox.Show(error);

                }

            }

            else
            {

                studentsListBox.ItemsSource = selectResult.Rows;

            }

        }

    }
}