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
    public partial class AgregarLocalizationPage : ContentPage
    {
        ItemLocalizationViewModel LocalizationVM;

        public AgregarLocalizationPage()
        {
            InitializeComponent();
            BindingContext = LocalizationVM = new ItemLocalizationViewModel();

            }

            private bool HayDatosRegistro()
            {
                bool R = false;
                if (TxtLocalization.Text != null)
                {
                    R = true;
                }
                return R;
            }

            private async void BtnAceptar_Clicked(object sender, EventArgs e)
            {

                if (HayDatosRegistro())
                {
                    bool R = await LocalizationVM.GuardarLocalization(TxtLocalization.Text.Trim());

                    if (R)
                    {
                        await DisplayAlert("Aviso", "Ubicación agregada correctamente", "OK");
                        await Navigation.PopAsync();
                    }
                    else
                    {
                        await DisplayAlert("Aviso", "Algo salió mal y la ubicación no se agregó", "OK");
                    }

                }
            }

            private async void BtnCancelar_Clicked(object sender, EventArgs e)
            {
                await Navigation.PopAsync();
            }
        }
    }