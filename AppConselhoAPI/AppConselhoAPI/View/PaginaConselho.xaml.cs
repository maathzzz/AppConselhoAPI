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
        public PaginaConselho()
        {
            InitializeComponent();
            this.BindingContext = new Conselho();
        }

        private void BtnAdvice_Clicked(object sender, EventArgs e)
        {
            // continuar aqui!
        }
    }
}