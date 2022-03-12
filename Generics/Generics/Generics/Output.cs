using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Generics
{
    static class Output
    {
        public static T OutputData<T>(string path)
        {
            using StreamReader streamReader = File.OpenText(path);
            string data = streamReader.ReadLine();
            using var ms = new MemoryStream(Encoding.Unicode.GetBytes(data));
            var deserializer = new DataContractJsonSerializer(typeof(T));
            T p = (T)deserializer.ReadObject(ms);
            return p;
        }
    }
}
