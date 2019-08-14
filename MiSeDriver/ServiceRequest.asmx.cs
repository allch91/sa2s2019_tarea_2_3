using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MiSeDriver
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
        /*
         * Método AvailableDriver verifica que exista un piloto cerca de la ubicación del usuario solicitante
         * Parámetros:
         * int user_pos_x: ubicación del usuario coordenada x
         * int user_pos_y: ubicación del usuario coordenada y
         * int user_pos_z: ubicación del usuario coordenada z
         */
        [WebMethod]
        public bool AvailableDriver(int user_pos_x, int user_pos_y, int user_pos_z)
        {
            if(true)
                return true;

            return false;
        }

        /*
         * Método DriverNotification envía la notificación al piloto disponible, si la notificación no se envía retorna falso
         * Parámetros:
         * string user_id: usuario que solicita el servicio
         * string user_phone: número de teléfono del usuario que solicita el servicio
         * int user_pos_x: ubicación del usuario coordenada x
         * int user_pos_y: ubicación del usuario coordenada y
         * int user_pos_z: ubicación del usuario coordenada z
         */

        [WebMethod]
        public bool DriverNotification(string user_id, string user_phone, int user_pos_x, int user_pos_y, int user_pos_z)
        {
            if (true)
                return true;

            return false;
        }

        /*
         * Método RegisterDriver almacena un nuevo conductor, si no se puede registrar retorna falso
         * Parámetros:
         * string driver_id: nuevo piloto a registrar
         * string driver_phone: número de teléfono del nuevo piloto
         * int driver_licence: número de licencia del nuevo piloto
         */

        [WebMethod]
        public bool RegisterDriver(string driver_id, string driver_phone, int driver_licence)
        {
            try
            {
                /*
                 * Attempt to save new driver
                 * Check not-existent driver
                 */
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
