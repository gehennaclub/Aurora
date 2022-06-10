using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Patcher.Profile
{
    public class Manager
    {
        public void save<T>(string path, T data)
        {
            Stream stream = File.Open(path, FileMode.Create);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            
            binaryFormatter.Serialize(stream, data);

            stream.Close();
        }

        public T load<T>(string path)
        {
            Stream stream = File.Open(path, FileMode.Open);
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            return (T)binaryFormatter.Deserialize(stream);
        }
    }
}
