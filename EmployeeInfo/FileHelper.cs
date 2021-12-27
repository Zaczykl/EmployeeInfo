using System.IO;
using System.Xml.Serialization;

namespace EmployeeInfo
{
    public class FileHelper<T> where T:new()
    {
        public void SerializeToFile(string path,T data)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(streamWriter, data);
                streamWriter.Close();
            }
        }

        public T DeserializeFromFile(string path)
        {
            if (File.Exists(path))
            {
                var serializer = new XmlSerializer(typeof(T));
                using (var streamReader = new StreamReader(path))
                {
                    T data = (T)serializer.Deserialize(streamReader);
                    streamReader.Close();
                    return data;
                }
            }
            else
                return new T();
        }
    }


}
