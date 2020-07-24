using System;

namespace ContactosAPP.Datos.Helpers
{
    public class Resultado
    {

        public static Resultado SendSuccess(string _Mensaje) => new Resultado() { Mensaje = _Mensaje, Estado = true };

        public static Resultado SendError() => new Resultado() { Mensaje = "Lo sentimos ha ocurrido un error inesperado. Favor intentelo nuevamente", Estado = false, Error = null };

        public static Resultado SendError(string _Mensaje) => new Resultado() { Mensaje = _Mensaje, Estado = false };

        public static Resultado SendError(string _Mensaje, string _Error) => new Resultado() { Mensaje = _Mensaje, Estado = false, Error = _Error };

        public static Resultado SendCrash(string _Error) => new Resultado() { Estado = false, Mensaje = "Lo sentimos ha ocurrido un error", Error = _Error };

        public Resultado SendCrash(Exception ex) => new Resultado() { Estado = false, Mensaje = "Lo sentimos ha ocurrido un error en la aplicación", Error = ex.Message };

        public static Resultado Send(System.Data.SqlClient.SqlDataReader reader)
        {
            try
            {
                Resultado retorno = new Resultado() { Estado = Convert.ToBoolean(reader.GetInt32(0)), Mensaje = reader["Message"].ToString(), Error = reader["Error"].ToString() };
                return retorno;
            }
            catch (Exception ex)
            {
                return new Resultado() { Estado = false, Mensaje = "Lo sentimos ha ocurrido un error", Error = ex.Message };
            }
        }

        public static Resultado Send(Boolean _Estado, String _Mensaje, String _Error) => new Resultado() { Estado = _Estado, Error = _Error, Mensaje = _Mensaje };
        /// <summary>
        /// Esto te indica si ocurrio un fallo o no True => todo esta ok. Flase => ah ocurrido un erro
        /// </summary>
        public bool Estado { get; set; }
        /// <summary>
        /// Mensajes generales 
        /// </summary>
        public String Mensaje { get; set; }
        /// <summary>
        /// Mensajes de errores no controlados
        /// </summary>
        public String Error { get; set; }
    }
}
