using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppConselhoAPI.Model;
using AppConselhoAPI.Services;
using AppConselhoAPI.View;

namespace AppConselhoAPI.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaConselho : ContentPage
    {
        public async void Default()
        {
            Conselho advice = await DataService.GetConselhoByNum("69");
            this.BindingContext = advice;
        }

        public PaginaConselho()
        {
            InitializeComponent();

            this.BindingContext = new Conselho();
            Default();

        }

        private async void BtnAdvice_Clicked(object sender, EventArgs e)
        {
            // continuar aqui!
            try
            {
                if (!String.IsNullOrEmpty(adviceEntry.Text))
                {
                    Conselho advice = await DataService.GetConselhoByNum(adviceEntry.Text);
                    this.BindingContext = advice;
                }
                else 
                {
                    Conselho advice = await DataService.GetConselhoRandom();
                    this.BindingContext = advice;
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "OK");
            }

        }
    }
}