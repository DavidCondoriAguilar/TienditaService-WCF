using pe.com.serviciotienditawcf.bo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pe.com.tienditaserviciowcf.bo;
using pe.com.tienditaserviciowcf_dal;

namespace pe.com.serviciotienditawcf.dal
{
    public class DALRol
    {
        Conexion objconexion = new Conexion();

        private SqlCommand cmdrol;
        private SqlDataReader drrol;
        int res = 0;

        public async Task<List<BORol>> MostrarRolAsync()
        {
            List<BORol> categorias = new List<BORol>();
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_MostrarRol";
                cmdrol.Connection = objconexion.Conectar();
                drrol = await cmdrol.ExecuteReaderAsync();
                while (await drrol.ReadAsync())
                {
                    BORol objrol = new BORol();
                    objrol.codigo = Convert.ToInt32(drrol["codrol"].ToString());
                    objrol.nombre = drrol["nomrol"].ToString();
                    objrol.estado = Convert.ToBoolean(drrol["estrol"].ToString());
                    categorias.Add(objrol);
                }
                return categorias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        public async Task<List<BORol>> MostrarRolTodoAsync()
        {
            List<BORol> categorias = new List<BORol>();
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_MostrarRolTodo";
                cmdrol.Connection = objconexion.Conectar();
                drrol = await cmdrol.ExecuteReaderAsync();
                while (await drrol.ReadAsync())
                {
                    BORol objrol = new BORol();
                    objrol.codigo = Convert.ToInt32(drrol["codcat"].ToString());
                    objrol.nombre = drrol["nomcat"].ToString();
                    objrol.estado = Convert.ToBoolean(drrol["estcat"].ToString());
                    categorias.Add(objrol);
                }
                return categorias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally
            {
                objconexion.CerrarConexion();
            }
        }

        public async Task<bool> RegistrarRolAsync(BOCategoria bc)
        {
            try
            {
                cmdrol = new SqlCommand();
                cmdrol.CommandType = CommandType.StoredProcedure;
                cmdrol.CommandText = "SP_RegistrarRol";
                cmdrol.Connection = objconexion.Conectar();

                cmdrol.Parameters.AddWithValue("@nombre", bc.nombre);
                cmdrol.Parameters.AddWithValue("@estado", bc.estado);

                res = await cmdrol.ExecuteNonQueryAsync();

                if (res == 1)
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
