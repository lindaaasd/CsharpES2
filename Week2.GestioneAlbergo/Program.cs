using System;

namespace Week2.GestioneAlbergo
{
    internal class Program
    {
        public const int MAX = 20;
        static void Main(string[] args)
        {
            string[] camere = new string[MAX];
            bool continua;
            do
            {
                continua = GestoreAlbergo.Menu(camere);
            } while (continua);
        }
    }
}
