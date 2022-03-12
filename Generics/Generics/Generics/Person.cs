using System;
using System.Runtime.Serialization;

namespace Generics
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
    }
}
