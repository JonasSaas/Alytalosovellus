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

namespace AlytalosovellusWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Lights valot1 = new Lights();
        public Lights valot2 = new Lights();
        public Sauna sauna1 = new Sauna();
        public Thermostat termo1 = new Thermostat();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOlohuoneValotOff_Click(object sender, RoutedEventArgs e)
        {
            txtOlohuoneenValot.Background = Brushes.White;
            valot1.LightsOff();
            txtOlohuoneenValot.Text = valot1.Dimmer;
        }

        private void BtnOlohuoneKirkas_Click(object sender, RoutedEventArgs e)
        {
            txtOlohuoneenValot.Background = Brushes.Yellow;
            valot1.LightsFull();
            txtOlohuoneenValot.Text = valot1.Dimmer;
        }

        private void BtnOlohuonePuolivalot_Click(object sender, RoutedEventArgs e)
        {
            txtOlohuoneenValot.Background = Brushes.Cyan;
            valot1.LightsTwoThird();
            txtOlohuoneenValot.Text = valot1.Dimmer;
        }

        private void BtnOlohuoneHamara_Click(object sender, RoutedEventArgs e)
        {
            txtOlohuoneenValot.Background = Brushes.LightBlue;
            valot1.LightsThird();
            txtOlohuoneenValot.Text = valot1.Dimmer;
        }

        private void BtnKeittioKirkas_Click(object sender, RoutedEventArgs e)
        {
            txtKeittionValot.Background = Brushes.Yellow;
            valot2.LightsFull();
            txtKeittionValot.Text = valot2.Dimmer;
        }

        private void BtnKeittioPuolivalot_Click(object sender, RoutedEventArgs e)
        {
            txtKeittionValot.Background = Brushes.Cyan;
            valot2.LightsTwoThird();
            txtKeittionValot.Text = valot2.Dimmer;
        }

        private void BtnKeittioHamara_Click(object sender, RoutedEventArgs e)
        {
            txtKeittionValot.Background = Brushes.LightBlue;
            valot2.LightsThird();
            txtKeittionValot.Text = valot2.Dimmer;
        }

        private void BtnKeittioValotOff_Click(object sender, RoutedEventArgs e)
        {
            txtKeittionValot.Background = Brushes.White;
            valot2.LightsOff();
            txtKeittionValot.Text = valot2.Dimmer;
        }

        private void BtnSaunaOn_Click(object sender, RoutedEventArgs e)
        {
            sauna1.SaunaOn();
            txtSauna.Text = "SAUNA PÄÄLLÄ";
            txtSauna.Background = Brushes.Orange;
        }

        private void BtnSaunaOff_Click(object sender, RoutedEventArgs e)
        {
            sauna1.SaunaOff();
            txtSauna.Text = " ";
            txtSauna.Background = Brushes.White;
        }

        private void BtnLampotilaAseta_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTavoiteLampotila.Text))
            {
                MessageBox.Show("Aseta Tavoite Lämpötila");
            }
            else
            {
                termo1.Temperature = int.Parse(txtTavoiteLampotila.Text);
                termo1.SetTemperature();
                txtTamanhetkinenLampotila.Text = termo1.Lampotila;
                txtTavoiteLampotila.Text = "";
            }
        }
    }
}
