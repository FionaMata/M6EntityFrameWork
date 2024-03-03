using CODE_FIRST.DAO;
using CODE_FIRST.MODEL;
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

namespace CODE_FIRST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CompanyDBContext companydbc = new CompanyDBContext();
        private IDAOManager manager = null;


        public MainWindow()
        {
            InitializeComponent();
            manager = DAOManagerFactory.CreateDaoManager(companydbc);

            //OK
            //manager.ImportOffices();
            //OK
            //manager.ImportEmployees();
            //OK
            //manager.ImportCustomers();            
            //OK
            //manager.ImportPayments();
            //OK
            //manager.ImportOrders();
            //OK
            //manager.ImportProductLines();
            //OK
            //manager.ImportProducts();
            //OK
            //manager.ImportOrderDetails();
        }


        private void cbSelects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbSelects.SelectedIndex == 0)
            {
                List<Customers> customerList = manager.ListCustomers();
                dgList.ItemsSource = customerList;
                dgList.Columns[12].Visibility = Visibility.Hidden;
                dgList.Columns[14].Visibility = Visibility.Hidden;
                dgList.Columns[15].Visibility = Visibility.Hidden;
            }
            else if (cbSelects.SelectedIndex == 1)
            {

            }
        }
    }
}