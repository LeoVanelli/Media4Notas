using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] _notas = new double[4];
            double _media = default;

            Console.WriteLine("-- Média --");
            Console.WriteLine("Digite suas notas abaixo.");

            for(int i = 0;i < 4;i++){
                Console.Write($"Nota {i+1}: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out _notas[i]);

                _media+=_notas[i];
            }

            _media/=4;

            for(int i = 0;i < 4;i++){
                if(_notas[i] < 0 || _notas[i] > 10){
                    Console.WriteLine("Digite somente notas entre 0 e 10.");
                    return;
                }
            }

            string _resultado = _media > 6 ? "Aprovado" : _media < 5 ? "Reprovado" : "Em recuperação";
            Console.WriteLine($"Você ficou com média {_media}. Resultado: {_resultado}");
        }
    }
}
