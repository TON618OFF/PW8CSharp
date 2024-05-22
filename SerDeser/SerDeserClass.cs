using System.IO;
using System.Text.Json;

namespace SerDeser
{
    public class SerDeserClass
    {
        public static void SerializeToFile<T>(T obj, string filePath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(obj);
                File.WriteAllText(filePath, jsonString);
                Console.WriteLine($"������ ������� ������������ � ������� � ����: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"������ ��� ������������ � ������ � ����: {ex.Message}");
            }
        }

        public static T DeserializeFromFile<T>(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    T obj = JsonSerializer.Deserialize<T>(jsonString);
                    Console.WriteLine($"������ ������� �������������� �� �����: {filePath}");
                    return obj;
                }
                else
                {
                    Console.WriteLine($"���� �� ������: {filePath}");
                    return default;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"������ ��� �������������� �� �����: {ex.Message}");
                return default;
            }
        }


    }
}
