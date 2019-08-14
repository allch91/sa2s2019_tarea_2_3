using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MiSeUser
{
    /// <summary>
    /// Descripción breve de ServiceRequest
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceRequest : System.Web.Services.WebService
    {
        /**
         * Método Request realiza la solicitud de servicio
         * Parámetros:
         * string user_id : usuario que solicita el servicio
         * string user_phone : teléfono del usuario que solicita el servicio
         * int user_pos_x : ubicación del usuario coordenada x
         * int user_pos_y : ubicación del usuario coordenada y
         * int user_pos_z : ubicación del usuario coordenada z
         */

        [WebMethod]
        public string Request(string user_id, string user_phone, int user_pos_x, int user_pos_y, int user_pos_z)
        {
            return "Debe retornar si existe un piloto disponible";
        }
    }
}
