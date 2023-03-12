using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double menorV = 0, maiorV = 0, mediaV = 0, acimaMedia = 0, aux = 0.0;

            String json = @"[
	{
		""dia"": 1,
		""valor"": 22174.1664
	},
	{
		""dia"": 2,
		""valor"": 24537.6698
	},
	{
		""dia"": 3,
		""valor"": 26139.6134
	},
	{
		""dia"": 4,
		""valor"": 0.0
	},
	{
		""dia"": 5,
		""valor"": 0.0
	},
	{
		""dia"": 6,
		""valor"": 26742.6612
	},
	{
		""dia"": 7,
		""valor"": 0.0
	},
	{
		""dia"": 8,
		""valor"": 42889.2258
	},
	{
		""dia"": 9,
		""valor"": 46251.174
	},
	{
		""dia"": 10,
		""valor"": 11191.4722
	},
	{
		""dia"": 11,
		""valor"": 0.0
	},
	{
		""dia"": 12,
		""valor"": 0.0
	},
	{
		""dia"": 13,
		""valor"": 3847.4823
	},
	{
		""dia"": 14,
		""valor"": 373.7838
	},
	{
		""dia"": 15,
		""valor"": 2659.7563
	},
	{
		""dia"": 16,
		""valor"": 48924.2448
	},
	{
		""dia"": 17,
		""valor"": 18419.2614
	},
	{
		""dia"": 18,
		""valor"": 0.0
	},
	{
		""dia"": 19,
		""valor"": 0.0
	},
	{
		""dia"": 20,
		""valor"": 35240.1826
	},
	{
		""dia"": 21,
		""valor"": 43829.1667
	},
	{
		""dia"": 22,
		""valor"": 18235.6852
	},
	{
		""dia"": 23,
		""valor"": 4355.0662
	},
	{
		""dia"": 24,
		""valor"": 13327.1025
	},
	{
		""dia"": 25,
		""valor"": 0.0
	},
	{
		""dia"": 26,
		""valor"": 0.0
	},
	{
		""dia"": 27,
		""valor"": 25681.8318
	},
	{
		""dia"": 28,
		""valor"": 1718.1221
	},
	{
		""dia"": 29,
		""valor"": 13220.495
	},
	{
		""dia"": 30,
		""valor"": 8414.61
	}]";

            List<String> list = new List<String>();

            String a;
            var data = JsonConvert.DeserializeObject<dynamic[]>(json);

            foreach (dynamic temp in data)
            {
                a = temp.valor;
                if (a != "0")
                {
                    //a = a.Replace(",", ".");
                    list.Add(a);
                }
            }

            menorV = Double.Parse(list[0]);
            menorV = Double.Parse(list[0]);
            mediaV = 0;

            for (int i = 0; i < list.Count; i++)
            {
                mediaV = mediaV + Convert.ToDouble(list[i], new CultureInfo("en-US"));
            }
            mediaV = mediaV / list.Count;

            Console.WriteLine("Lista gerada: ");
            for (int i = 0; i < list.Count; i++)
            {
                //Console.WriteLine(">>"+list[i]);
                String f = list[i];
                aux = Convert.ToDouble(f, new CultureInfo("en-US"));

                Console.WriteLine(aux);
                if (menorV > aux) { menorV = aux; }
                if (maiorV < aux) { maiorV = aux; }
                if (aux > mediaV) { acimaMedia++; }
            }

            Console.WriteLine("\nMenor valor: R$ " + menorV);
            Console.WriteLine("Maior valor: R$ " + maiorV);
            Console.WriteLine("Qtd dias acima da média: " + acimaMedia);

            Console.WriteLine("\nMédia mensal: R$ " + mediaV);

            Console.WriteLine("");
            Console.ReadKey();

        }
    }
    
}
