using System.Net.Sockets;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rocket rocket;
        private Astronaut astronaut;
        private InsuranceCompany insuranceCompany;

        public MainWindow()
        {
            InitializeComponent();
            rocket = new Rocket();
            astronaut = new Astronaut();
            insuranceCompany = new InsuranceCompany();

            rocket.LaunchSuccessful += RocketLaunchSuccessfulHandler;
            rocket.Accident += RocketAccidentHandler;
        }

        private void LaunchRocket_Click(object sender, RoutedEventArgs e)
        {
            LaunchRocket();
        }

        private void LaunchRocket()
        {
            rocket.Launch();
        }

        private void RocketLaunchSuccessfulHandler(object sender, EventArgs e)
        {
            astronaut.ExitIntoOpenSpace();
        }

        private void RocketAccidentHandler(object sender, EventArgs e)
        {
            insuranceCompany.PayCompensation();
        }
    }
}