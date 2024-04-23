using Newtonsoft.Json;

namespace File__Directory__StreamWriter__StreamReader__Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Add("Nurlan");

            Add("absckjml");
            /*Delete("Nurlan");*/
        }

        public static List<string> Deserialize(string path)
        {
            string result;


            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }

            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
        public static void Serialize<T>(string path, T obj)
        {
            string result = JsonConvert.SerializeObject(obj);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(result);
            }
        }
        public static void Add(string name)
        {
           
            List<string> names = Deserialize(@"C:\Users\Hp\OneDrive\Desktop\File, Directory, StreamWriter, StreamReader, Serialize\File, Directory, StreamWriter, StreamReader, Serialize\Files\names.json");
            names.Add(name);
            Serialize(@"C:\Users\Hp\OneDrive\Desktop\File, Directory, StreamWriter, StreamReader, Serialize\File, Directory, StreamWriter, StreamReader, Serialize\Files\names.json", names);

        }
        
        public static bool Search (string name)
        {
            
            List<string> names = Deserialize(@"C:\Users\Hp\OneDrive\Desktop\File, 
                  Directory, StreamWriter, StreamReader, Serialize\File, Directory, StreamWriter, StreamReader, Serialize\Files\names.json");
          
            if (names.Contains(name)) 
            {

                return true; 
            }
            else
            { 
                return false;
            }

            Serialize<List<string>>(@"C:\Users\Hp\OneDrive\Desktop\File, 
                  Directory, StreamWriter, StreamReader, Serialize\File, Directory, StreamWriter, StreamReader, Serialize\Files\names.json", names);
        }
        public static void Delete(string name)
        {
           
            List<string> names = Deserialize(@"C:\Users\Hp\OneDrive\Desktop\File, Directory, StreamWriter, StreamReader, Serialize\File, Directory, StreamWriter, StreamReader, Serialize\Files\names.json");
            if (names.Contains(name))
            {
                names.Remove(name);

                Console.WriteLine($"{name}- deleted!");
            }
           
            Serialize<List<string>>(@"C:\Users\Hp\OneDrive\Desktop\File, Directory, StreamWriter, StreamReader, Serialize\File, Directory, StreamWriter, StreamReader, Serialize\Files\names.json", names);

        }
    }
}
