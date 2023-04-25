using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinCalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnHesapla_OnClicked(object sender, EventArgs e)
        {
            if (entrySayi1.Text == null || entrySayi2.Text == null)
            {
                DisplayAlert("Hata!", "Lütfen tüm alanları doldurunuz.", "Kapat");
                return;
            }
            var sayi1 = Convert.ToDouble(entrySayi1.Text);
            var sayi2 = Convert.ToDouble(entrySayi2.Text);
            var btn = (Button)sender;
            double sonuc = 0;
            switch (btn.Text)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                                        break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
                default:
                    lblSonuc.Text = "İşlem Başarısız";
                    break;
            }
            lblSonuc.Text = sonuc.ToString();
            lblSnc.IsVisible = true;
            lblSonuc.IsVisible = true;
        }
    }
}
