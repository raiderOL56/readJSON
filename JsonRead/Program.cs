using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lectura de nuestro archivo .json
using System.IO;

using Newtonsoft.Json;

namespace JsonRead
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leemos el archivo 'archivo.json' 
            using (StreamReader archivo = File.OpenText(@"C:\Users\erick\source\repos\JsonRead\JsonRead\bin\Debug\archivo.json"))

            {
                // Leemos los datos del archivo 'archivo.json' desde el inicio hasta el final 
                string json = archivo.ReadToEnd();

                // Deserializamos el archivo 'archivo.json' 
                dynamic miarray = JsonConvert.DeserializeObject(json);

                // Recorremos el array que contiene los datos de 'archivo.json'
                foreach (var item in miarray)
                {
                    // Mostrar cada uno de los campos del 'archivo.json'
                    Console.WriteLine(item.Servicio);
                }
            }

            Console.ReadLine();
        }
    }
}
