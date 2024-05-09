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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        //CATEGORIA
        [OperationContract]
        List<BOCategoria> MostrarCategoria();

        [OperationContract]
        List<BOCategoria> MostrarCategoriaTodo();

        [OperationContract]
        bool RegistrarCategoria(BOCategoria bc);

        [OperationContract]
        bool ActualizarCategoria(BOCategoria bc);

        [OperationContract]
        bool EliminarCategoria(BOCategoria bc);

        //PRODUCTO

        [OperationContract]
        List<BOProducto> MostrarProducto();

        [OperationContract]
        List<BOProducto> MostrarProductoTodo();

        [OperationContract]
        bool RegistrarProducto(BOProducto bc);

        [OperationContract]
        bool ActualizarProducto(BOProducto bc);

        [OperationContract]

        bool EliminarProducto(BOProducto bc);

    }


}
