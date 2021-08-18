using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyStuff_Yilka.ViewModels;

namespace MyStuff_Yilka.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarItemPage : ContentPage
    {
        ItemViewModel VmItem;

        public AgregarItemPage()
        {
            InitializeComponent();

            BindingContext = VmItem = new ItemViewModel();

            //Ahora agregamos la fuente de datos al combo de monedas 
            CboMoneda.ItemsSource = VmItem.CurrenciesList;

        }

        private async void BtnAceptar_Clicked(object sender, EventArgs e)
        {
            bool R = await VmItem.GuardarItem(TxtNombre.Text.Trim(),
                                              TxtDescripcion.Text.Trim(),
                                              Convert.ToDecimal(TxtCosto.Text.Trim()),
                                              TxtSerie.Text.Trim(),
                                              TxtNumeroFactura.Text.Trim(),
                                              Convert.ToDecimal(TxtDepreciacion.Text.Trim()));
            if (R)
            {
                await DisplayAlert("Aviso", "Item agregado correctamente", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Aviso", "Algo salió mal y el Item no se agregó", "OK");
            }
        }

        private void BtnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}