using SKHPay.Domain;
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

namespace SKHPay
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public Client client = new Client();
    public string summToPay;
    public MainWindow()
    {
      InitializeComponent();
      using (ClassContext context = new ClassContext())
      {
        
      }
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
      client.IIN = IIN_Field.Text;
    }

    private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
    {
      client.StreetName = Street_Field.Text;
    }

    private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
    {
      client.HouseNumber = HouseNumber_Field.Text;
    }

    private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
    {
      client.FlatsNumber = FlatNumber_Field.Text;
    }

    private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
    {
      client.PhoneNumber = FlatNumber_Field.Text;
    }

    private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
    {
      summToPay = Summ_Field.Text;
    }

    private void Confirm_Button_Click(object sender, RoutedEventArgs e)
    {
      using (var context = new ClassContext())
      {
        int month = 1;
        if (context.Clients.Where(a=>a.IIN.Equals(client.IIN)).Any())
        {
          client = context.Clients.Where(a => a.IIN.Equals(client.IIN)).FirstOrDefault();
         month = client.Payments.Last().Month + 1;

        }
        Payment payment = new Payment
        {
          MustInTotal = summToPay,
          Month =  month
        };
        context.Payments.Add(payment);

        context.Clients.Add(client);
        context.SaveChanges();
      }
    }
  }
}
