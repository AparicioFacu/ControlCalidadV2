using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;
using System.Text;

namespace ServidorSemaforo
{
    public class Serializacion
    {
        public static byte[] Serializate(object toSerializate)
        {
            MemoryStream memory = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(memory, toSerializate);

            return memory.ToArray();
        }
        public static object Deserializate(byte[] data)
        {
            MemoryStream memory = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(memory);
        }
    }
}
