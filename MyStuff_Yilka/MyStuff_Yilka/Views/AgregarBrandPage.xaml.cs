using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyStuff_Yilka.ViewModels;
using MyStuff_Yilka.Clases;

namespace MyStuff_Yilka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarBrandPage : ContentPage
    {
        BrandViewModel BrandVM;

        public AgregarBrandPage()
        {
            InitializeComponent();

            BindingContext = BrandVM = new BrandViewModel();
        }

        private bool HayDatosRegistro()
        {
            bool R = false;
            if (TxtBrand.Text != null)
            {
                R = true;
            }
            return R;
        }

        private async void BtnAceptar_Clicked(object sender, EventArgs e)
        {

            if (HayDatosRegistro())
            {
                bool R = await BrandVM.GuardarBrand(TxtBrand.Text.Trim());

                if (R)
                {
                    await DisplayAlert("Aviso", "Marca agregada correctamente", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Aviso", "Algo salió mal y la marca no se agregó", "OK");
                }

            }
        }

        private async void BtnCancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}