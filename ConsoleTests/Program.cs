using StackExchange.Redis.Extensions.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Text;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Directory.GetCurrentDirectory();
            var path = $"{directory}/test.json";

            var content = File.ReadAllText(path);

            var lista = JsonConvert.DeserializeObject<List<dynamic>>(content);
            string texto = string.Empty;
            foreach(var objeto in lista)
            {
                texto += $"{objeto.Name}:{objeto.SKU}{Environment.NewLine}";
            }


            File.WriteAllText($"{directory}/SkuList.txt", texto, Encoding.UTF8);
        }
    }
}
