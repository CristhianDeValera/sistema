using System;
using System.Data.SqlClient;
using System.Data;

namespace Sistema.Datos
{
    public class DRol
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado; //SqlDataReader: Proporciona una forma de leer una secuencia de filas.
            DataTable Tabla = new DataTable(); //DataTable: Esta clase representa una tabla en memoria.
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("rol_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);

                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // en este if, indicamos si existe la conexion la cerramos.
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}
