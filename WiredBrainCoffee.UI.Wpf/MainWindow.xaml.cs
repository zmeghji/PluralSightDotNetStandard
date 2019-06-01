using System.Windows;
using WiredBrainCoffee.Simulator;
namespace WiredBrainCoffee.UI.Wpf
{

    public partial class MainWindow : Window
    {
        private readonly CoffeeMachine _coffeeMachine;
        public MainWindow()
        {
            InitializeComponent();
            _coffeeMachine = new CoffeeMachine();
            txtCappuccinoCounter.Text = _coffeeMachine.CounterCappuccino.ToString();
        }

        private void ButtonMakeCappuccinoClick(object sender, RoutedEventArgs e)
        {
            _coffeeMachine.MakeCappuccino();
            txtCappuccinoCounter.Text = _coffeeMachine.CounterCappuccino.ToString();
        }

        private void ButtonShowStoredStateClick(object sender, RoutedEventArgs e)
        {
            _coffeeMachine.ShowStoredState();
            //_coffeeMachine.sh
        }
    }
}
