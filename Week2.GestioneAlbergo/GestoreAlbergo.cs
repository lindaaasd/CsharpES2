using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.GestioneAlbergo
{
    internal static class GestoreAlbergo
    {
        public static bool Menu(string[] camere)
        {
            bool continua = true;
            PrintMenu();
            int scelta = VerificaInputIntero();
            switch (scelta)
            {
                case 0:
                    continua = false;
                    return continua;
                case 1:
                    //Inserimento di un nuovo cliente
                    InserimentoCliente(camere);
                    break;
                case 2:
                    //Stampa camere occupate
                    StampaCamereOccupate(camere);
                    break;
                case 3:
                    //Stampa camere non occupate
                    StampaCamereVuote(camere);
                    break;
                case 4:
                    //Cerca cliente
                    CercaCliente(camere);
                    break;
                default:
                    continua = false;
                    return continua;
            }

            return continua;
        }

        public static void CercaCliente(string[] camere)
        {
            Console.WriteLine("Inserire cliente da cercare");
            string clienteDaCercare = Console.ReadLine();
            int indexTrovato = Array.IndexOf(camere, clienteDaCercare);
            if(indexTrovato == -1)
            {
                Console.WriteLine("Cliente non trovato");
            }
            else
            {
                Console.WriteLine("Cliente {0} trovato nella camera n.{1}",
                     clienteDaCercare, indexTrovato);
            }
        }

        public static void StampaCamereVuote(string[] camere)
        {
            int numeroCamereVuote = 0;
            for(int i = 0; i < camere.Length; i++)
            {
                if(camere[i] == null)
                {
                    Console.WriteLine($"La camera n.{i} è vuota");
                    numeroCamereVuote++;
                }
            }
            Console.WriteLine($"N. camere vuote: {numeroCamereVuote}");
        }

        public static void StampaCamereOccupate(string[] camere)
        {
            //foreach(string cliente in camere)
            //{
            //    if(cliente != null)
            //    {
            //        Console.WriteLine("Cliente: " + cliente);
            //    }
            //}
            for(int i = 0; i < camere.Length; i++)
            {
                if(camere[i] != null)
                {
                    Console.WriteLine("Camera n." + i + "- Cliente: " + camere[i]);
                }
            }
        }

        public static void InserimentoCliente(string[] camere)
        {
            Console.WriteLine("Quante camere vuoi inserire?");
            int numCamere = VerificaInputIntero();
            int numeroCameraSelezionata;
            for(int i = 0; i < numCamere; i++)
            {
                Console.WriteLine("Inserisci numero camera (tra 0 e 19)");
                numeroCameraSelezionata = VerificaInputIntero();
                //TODO: verificare che la camera scelta non sia già piena
                Console.WriteLine("Inserisci cliente");
                camere[numeroCameraSelezionata] = Console.ReadLine();
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Inserisci nuovo cliente");
            Console.WriteLine("2. Stampa camere occupate");
            Console.WriteLine("3. Stampa camere vuote");
            Console.WriteLine("4. Cercare cliente");
            Console.WriteLine("0. Esci");
        }

        public static int VerificaInputIntero()
        {
            int valoreIntero;
            bool conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            while(!conversion || valoreIntero < 0)
            {
                Console.WriteLine("Inserisci un valore corretto");
                conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            }
            return valoreIntero;
        }
    }
}
