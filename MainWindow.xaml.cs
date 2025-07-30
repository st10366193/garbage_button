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

namespace garbage_button
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
        // display the garbage 

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // creating an instance for the object building function class 

            object current_gen = new object();

            // getting the generation automatically 

            GC.GetGeneration(current_gen);

            // displaying the total memory that is any gen found   

            memory.Text = "" + GC.GetTotalMemory(false);
        }
    }
}