using System;
using System.Collections.Generic;
using System.Text;
using MyStuff_Yilka.Models;

namespace MyStuff_Yilka
{
    public static class ObjetosGlobales
    {
        //Acá almacenamos la información que permite el consumo de las rutas de producción y pruebas 
        //del API 
        public static string RutaProduccion = "http://169.254.114.36:45455/api/";
        public static string RutaPruebas = "http://169.254.114.36:45455/api/";

        //agregamos la info de seguridad ya sea JWT o ApiKey como en este caso 
        public static string ApiKeyName = "ApiKey";
        public static string ApiKeyValue = "1234qwertyABC";

        public static User MiUsuarioGlobal = new User();
    }
}
