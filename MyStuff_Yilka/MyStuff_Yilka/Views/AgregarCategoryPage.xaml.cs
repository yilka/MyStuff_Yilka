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
    public partial class AgregarCategoryPage : ContentPage
    {
        ItemCategoryViewModel CategoryVM;

        public AgregarCategoryPage()
        {
            InitializeComponent();
            BindingContext = CategoryVM = new ItemCategoryViewModel();

        }

        private bool HayDatosRegistro()
        {
            bool R = false;
            if (TxtCategory.Text != null)
            {
                R = true;
            }
            return R;
        }

        private async void BtnAceptar_Clicked(object sender, EventArgs e)
        {

            if (HayDatosRegistro())
            {
                bool R = await CategoryVM.GuardarCategory(TxtCategory.Text.Trim());

                if (R)
                {
                    await DisplayAlert("Aviso", "Categoria agregada correctamente", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Aviso", "Algo salió mal y la categoria no se agregó", "OK");
                }

            }
        }

        private async void BtnCancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}