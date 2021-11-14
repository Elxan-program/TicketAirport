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
using System.Windows.Shapes;
using TicketAirport.DataAccess.SwlServer;

namespace TicketAirport.Domain.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirplaneRepostory AirplaneRepostory = new AirplaneRepostory();
        CityRepostory CityRepostory = new CityRepostory();
        ScheludeRepostory ScheludeRepostory = new ScheludeRepostory();
        PilotRepostory PilotRepostory = new PilotRepostory();
        DBEntities1 DBEntities = new DBEntities1();
        City City = new City();
        Airplane Airplane = new Airplane();
        Schedule Schedule = new Schedule();
        public MainWindow()
        {
            InitializeComponent();
            CitiesCombobox.ItemsSource = CityRepostory.GetAllData();
            SchedulesComboBox.ItemsSource = ScheludeRepostory.GetAllData();
            AirplaneComboBox.ItemsSource = AirplaneRepostory.GetAllData();
        }
    }
}
