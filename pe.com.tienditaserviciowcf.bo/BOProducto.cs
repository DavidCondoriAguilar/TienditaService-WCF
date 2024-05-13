using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.tienditaserviciowcf.bo
{
    [DataContract]
    [Serializable]
    public class BOProducto
    {
        public int codigo { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string descripcion { get; set; }
        [DataMember]
        public double precio { get; set; }
        [DataMember]
        public double cantidad { get; set; }
        [DataMember]
        public bool estado { get; set; }
        [DataMember]
        public BOCategoria categoria { get; set; } 
    }
}
