using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuyAlcohol
{
    public partial class MainPage : ContentPage
    {
        public DateTime dob;
        public int age;
        public DateTime today;

        public MainPage()
        {
            InitializeComponent();
        }

        public void OnDateSelected(Object sender, DateChangedEventArgs args)
        {
            dob = Input_DOB.Date;

            today = DateTime.Today;

            age = today.Year - dob.Year;

            if (today.Month < dob.Month || (today.Month == dob.Month && today.Day < dob.Day))
            {
                age--;
            }
        }


        public void Calc_Age(Object sender, System.EventArgs e)
        {
            // age = Int32.Parse(Input_Age.Text);
            int usa, vsa, wsa, xsa, beforeAge21;



            //usa legal age
            if (age < 21)
            {
                usa = 21 - age;
            } else
            {
                usa = 0;
            }

            //vsa legal age
            if (age < 18)
            {
                vsa = 25 - age;
            }
            else
            {
                vsa = 0;
            }

            //wsa legal age
            if (age < 16)
            {
                wsa = 30 - age;
            }
            else
            {
                wsa = 0;
            }

            //xsa legal age
            if (age < 22)
            {
                xsa = 35 - age;
            }
            else
            {
                xsa = 0;
            }

            Before.Text = $"Years before turning 21: {usa}";
            USA.Text = $"USA: {usa} years before buying";
            VSA.Text = $"VSA: {vsa} years before buying";
            WSA.Text = $"WSA: {wsa} years before buying";
            XSA.Text = $"XSA: {xsa} years before buying";

        }

        public void Add_Country_Clicked(Object sender, EventArgs eventArgs)
        {
            DisplayAlert("Add Country", "Add was selected", "Button 2", "Button 1");
        }
    }
}
