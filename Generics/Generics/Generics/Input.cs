using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Generics
{
    static class Input
    {
        public static void InputData<T>(T data, string path)
        {
            if (!File.Exists(path))
            {
                using var stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                var serializer = new DataContractJsonSerializer(typeof(T));
                using var ms = new MemoryStream();
                serializer.WriteObject(ms, data);
                ms.Position = 0;
                using var reader = new StreamReader(ms);
                string json = reader.ReadToEnd();
                using var writer = new StreamWriter(stream);
                writer.WriteLine(json);
            }
        }
    }
}
