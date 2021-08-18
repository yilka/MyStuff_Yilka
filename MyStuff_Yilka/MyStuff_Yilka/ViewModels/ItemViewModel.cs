using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using MyStuff_Yilka.Models;

namespace MyStuff_Yilka.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        //atribs del vm 

        public Item MyItem { get; set; }

        //este objeto será gestionado cada vez que cambiemos una moneda en el picker, de forma que luego podamos 
        //extraer la info que necesitamos de este objeto para asignar a MyItem
        public Currency MyCurrency { get; set; }

        //esta será la lista que usaremos para alimentar con datos el picke de monedas 
        public List<Currency> CurrenciesList { get; set; }

        //contructor
        public ItemViewModel()
        {
            MyItem = new Item();

            MyCurrency = new Currency();

            CurrenciesList = new List<Currency>();

            //esta lista de monedas no tiene datos aún, estos datos los cargaremos acá en el contructor
            CurrenciesList = ListarMonedas();

        }

        //métodos y funciones
        public ObservableCollection<Item> ListarItems()
        {
            if (IsBusy)
            {
                return null;
            }
            else
            {
                try
                {
                    return MyItem.ListarItems();
                }
                catch (Exception ex)
                {

                    return null;
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }

        private List<Currency> ListarMonedas()
        {
            if (IsBusy)
            {
                return null;
            }
            else
            {
                try
                {
                    return MyCurrency.ListarMonedas();
                }
                catch (Exception ex)
                {

                    return null;
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }


        //función para agregar un item nuevo
        public async Task<bool> GuardarItem(string nombre, string descripcion, decimal costo,
                                            string numeroserie, string numfactura, decimal depreciacion)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                MyItem.ItemName = nombre;
                MyItem.ItemDescription = descripcion;
                MyItem.ItemCost = costo;
                MyItem.SerialNumber = numeroserie;
                MyItem.InvoiceNumber = numfactura;
                MyItem.ExRate = depreciacion;

                //TODO: asignar el ID del usuario por medio del usuario global 
                MyItem.UserId = ObjetosGlobales.MiUsuarioGlobal.UserId;

                //ahora hay que asignar los valores del ID de las composiciones (en este caso moneda) 
                MyItem.CurrencyId = MyCurrency.CurrencyId;

                //TODO: agregar los valores para los restantes pickers

                bool R = await MyItem.GuardarItem();

                return R;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                IsBusy = false;
            }

        }



    }
}
