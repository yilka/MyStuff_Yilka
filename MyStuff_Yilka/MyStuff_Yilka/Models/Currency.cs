using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Text;

namespace MyStuff_Yilka.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Items = new HashSet<Item>();
        }

        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencySym { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        //Necesitamos una función que entregue la lista de las monedas para dibujarlas el picker (Combo Box) de las monenas 
        //en el form de ingreso de Item

        public List<Currency> ListarMonedas()
        {
            string SufijoRuta = string.Format("Currencies");

            string RutaConsumoAPI = ObjetosGlobales.RutaProduccion + SufijoRuta;

            var client = new RestClient(RutaConsumoAPI);

            var request = new RestRequest(Method.GET);

            //agregamos la info de seguridad 
            request.AddHeader(ObjetosGlobales.ApiKeyName, ObjetosGlobales.ApiKeyValue);

            //ejecuta de forma síncrona la consulta contra el API
            IRestResponse Respuesta = client.Execute(request);

            HttpStatusCode CodigoRespuesta = Respuesta.StatusCode;

            var ListaMonedas = JsonConvert.DeserializeObject<List<Currency>>(Respuesta.Content);

            if (CodigoRespuesta == HttpStatusCode.OK)
            {
                return ListaMonedas;
            }
            else
            {
                return null;
            }
        }


    }
}

