using System;
using System.Runtime.Serialization;

namespace Generics
{
    [DataContract]
    public class Furniture
    {
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public int Count { get; set; }
    }
}
