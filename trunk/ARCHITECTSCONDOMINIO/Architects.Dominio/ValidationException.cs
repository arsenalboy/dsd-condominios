using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Architects.Dominio
{
    [DataContract]
    public class ValidationException
    {
        [DataMember]
        public string ValidationError { get; set; }
    }
}
