using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Idm
{
    class Program
    {
        static void Main(string[] args)
        {
            string endereco = "https://avena.azurewebsites.net/";

            string resposta = new HttpClient().GetStringAsync(endereco).Result;

            Console.WriteLine(resposta);
            Console.ReadKey();





        }
    }
}
