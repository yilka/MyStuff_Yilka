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
    public partial class AgregarSupplierPage : ContentPage
    {
        SupplierViewModel SupplierVM;

        public AgregarSupplierPage()
        {
            InitializeComponent();
            BindingContext = SupplierVM = new SupplierViewModel();

        }

        private bool HayDatosRegistro()
        {
            bool R = false;
            if (TxtName.Text != null && TxtPhone.Text != null && TxtEmail.Text != null)
            {
                R = true;
            }
            return R;
        }

        private async void BtnAceptar_Clicked(object sender, EventArgs e)
        {

            if (HayDatosRegistro())
            {
                bool R = await SupplierVM.GuardarSupplier(TxtName.Text.Trim(), TxtPhone.Text.Trim(), TxtEmail.Text.Trim());

                if (R)
                {
                    await DisplayAlert("Aviso", "Proveedor agregado correctamente", "OK");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Aviso", "Algo salió mal y el proveedor no se agregó", "OK");
                }

            }
        }

        private async void BtnCancelar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}