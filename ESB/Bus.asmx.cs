using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ESB
{
    /// <summary>
    /// Descripción breve de Bus
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Bus : System.Web.Services.WebService
    {
        /*
         * Método MiSeUser encargado del envío de mensajes para el microservicio de usuarios
         * Parámetros:
         * string new_user_data: colección de parámetros para el microservicio de usuarios
         */
        [WebMethod]
        public bool MiSeUser(string mis_euser_data)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Método MiSeDriver encargado del envío de mensajes para el microservicio de pilotos
         * Parámetros:
         * string mise_driver_data: colección de parámetros para el microservicio de pilotos
         */
        [WebMethod]
        public bool MiSeDriver(string mise_driver_data)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Método MiSeCarTracking encargado del envío de mensajes para el microservicio de rastreo de vehículos
         * Parámetros:
         * string tracking_data: colección de parámetros para el microservicio de rastreo de vehículos
         */
        [WebMethod]
        public bool CarTracking(string tracking_data)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Método QueueMessage cola de mensajes en espera a ser transmitidos
         * Parámetros:
         * string service_name: nombre del servicio solicitado
         * string service_data: colección de parámetros para el microservicio solicitado
         */
        [WebMethod]
        public bool QueueMessage(string service_name, string service_data)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }

        /*
         * Método Log encargado de registrar los mensajes y el estado de los mismos
         * Parámetros:
         * string service_name: nombre del servicio solicitado
         * string service_data: colección del paramétros para el microservicio solicitado
         * int status: estado del mensaje; -1 -> incorrecto; 0 -> correcto ; 1 -> en espera
         */
        [WebMethod]
        public bool Log(string service_name, string service_data, int status)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
