using pe.com.serviciotienditawcf.bo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.tienditaserviciowcf_dal;

namespace pe.com.serviciotienditawcf.dal
{
    public class DALEmpleado
    {
        Conexion objconexion = new Conexion();

        private SqlCommand cmdemp;
        private SqlDataReader dremp;
        int res = 0;

        public bool ValidarEmpleado(BOEmpleado be)
        {
            int cont = 0;
            try
            {
                cmdemp = new SqlCommand();
                cmdemp.CommandType = CommandType.StoredProcedure;
                cmdemp.CommandText = "SP_ValidarEmpleado";
                cmdemp.Connection = objconexion.Conectar();

                cmdemp.Parameters.AddWithValue("@nombre", be.usuario);
                cmdemp.Parameters.AddWithValue("@estado", be.clave);

                dremp = cmdemp.ExecuteReader();
                while (dremp.Read())
                {
                    cont++;
                }

                if (cont == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }
    }
}
