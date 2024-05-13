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
    public class BODistrito
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public bool estado { get; set; }
    }
}