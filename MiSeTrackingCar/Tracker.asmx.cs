using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MiSeTrackingCar
{
    /// <summary>
    /// Descripción breve de Tracker
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Tracker : System.Web.Services.WebService
    {
        /*
         * Método CarPosition retorna las coordenadas de la ubicación del vehículo solicitado
         * Parámetros:
         * string car_id: número de placa del vehículo a restrear
         */
        [WebMethod]
        public string CarPosition(string car_id)
        {
            return "car_pos_x; car_pos_y; car_pos_z";
        }
    }
}
