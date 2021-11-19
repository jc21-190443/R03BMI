using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A34 前川　龍之介";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String height = heighit.Text;
            String weight = weighit.Text;
            try
            {
                double h = double.Parse(height);
                double w = double.Parse(weight);

                if (h > 10)
                {
                    h = h / 100;
                }

                if(w > 5000)
                {
                    w = w / 1000;
                }


                double bmi = w / h / h;

                bmi = (Math.Round(bmi,1, MidpointRounding.AwayFromZero));

               

                if (bmi < 18.5)
                {
                    result.Text ="BMI："+ bmi + "状態：　低体重（瘦せ）";
                }
                else if (bmi < 25)
                {
                    result.Text = "BMI："+ bmi + "状態：　普通体重";
                }
                else if (bmi < 30)
                {
                    result.Text = "BMI："+ bmi + "状態：　肥満（1度）";
                }
                else if (bmi < 35)
                {
                    result.Text = "BMI：" + bmi + "状態：　肥満（2度）";
                }
                else if (bmi < 40)
                {
                    result.Text = "BMI：" + bmi + "状態：　肥満（3度）";
                }
                else if (bmi >= 40)
                {
                    result.Text = "BMI：" + bmi + "状態：　肥満（4度）";
                }
            }catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
