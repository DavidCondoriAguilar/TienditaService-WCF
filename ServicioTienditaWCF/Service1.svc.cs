using pe.com.serviciotienditawcf.dal;
using pe.com.tienditaserviciowcf.bo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioTienditaWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        DALCategoria dalcat = new DALCategoria();
        DALProducto dalpro = new DALProducto();


        public List<BOCategoria> MostrarCategoria()
        {
            return dalcat.MostrarCategoria();
        }

        public List<BOCategoria> MostrarCategoriaTodo()
        {
            return dalcat.MostrarCategoriaTodo();
        }

        public bool RegistrarCategoria(BOCategoria bc)
        {
            return dalcat.RegistrarCategoria(bc);
        }

        public bool ActualizarCategoria(BOCategoria bc)
        {
            return dalcat.ActualizarCategoria(bc);
        }

        public bool EliminarCategoria(BOCategoria bc)
        {
            return dalcat.EliminarCategoria(bc);
        }

        //CATEGORIA


        public List<BOProducto> MostrarProducto()
        {
            return dalpro.MostrarProducto();
        }

        public List<BOProducto> MostrarProductoTodo()
        {
            return dalpro.MostrarProductoTodo();
        }

        public bool RegistrarProducto(BOProducto bc)
        {
            return dalpro.RegistrarProducto(bc);
        }

        public bool ActualizarProducto(BOProducto bc)
        {
            return dalpro.ActualizarProducto(bc);
        }

        public bool EliminarProducto(BOProducto bc)
        {
            return dalpro.EliminarProducto(bc);
        }
    }
}
