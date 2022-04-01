using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_kelompok_123
{
    internal class DataMahasiswa1302200012
    {
        public static void ReadJSON()
        {
            String a = File.ReadAllText("C:/Users/desak/Documents/SEMESTER 4/Konstruksi Perangkat Lunak/TPMOD6/TP_KPL6/tpmodul6_kelompok_123/tpmodul6_kelompok_123/tp6_1_1302200012.json");
            dynamic mhs = JsonConvert.DeserializeObject(a);
            Console.WriteLine("Nama: " + mhs.nama.depan + " " + mhs.nama.belakang + " dengan nim " + mhs.nim + " fakultas " + mhs.fakultas);
        }

    }
}
