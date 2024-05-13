using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace pe.com.serviciotienditawcf.bo
{
    [DataContract]
    [Serializable]
    public class BOEmpleado
    {
        //declarando los atributos
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public string apellidopaterno { get; set; }
        [DataMember]
        public string apellidomaterno { get; set; }
        [DataMember]
        public string documento { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }
        public string direccion { get; set; }
        [DataMember]
        public string telefono { get; set; }
        [DataMember]
        public string celular { get; set; }
        [DataMember]
        public string correo { get; set; }
        [DataMember]
        public string sexo { get; set; }
        [DataMember]
        public string usuario { get; set; }
        [DataMember]
        public string clave { get; set; }
        public bool estado { get; set; }
        [DataMember]
        public BODistrito distrito { get; set; }
        [DataMember]
        public BORol rol { get; set; }

    }
}
