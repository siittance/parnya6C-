using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CalendarEmocia1.ViewModel.Helpers
{
    internal class Converter
    {
        static string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public void Sirialize<tipe>(tipe data, string path)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(desktop + "\\" + path, json);

        }

        public tipe Deserialization<tipe>(string path)
        {
            string json = "";
            try
            {
                json = File.ReadAllText(desktop + "\\" + path);
            }
            catch (Exception)
            {
                File.Create(desktop + "\\" + path).Close();
                json = File.ReadAllText(desktop + "\\" + path);
            }
            tipe data = JsonConvert.DeserializeObject<tipe>(json);
            return data;
        }
    }
}
