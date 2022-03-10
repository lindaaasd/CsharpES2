using System;
using System.Collections.Generic;
using System.Text;

namespace Week2.GestioneCopisteria
{
    internal static class GestoreCopisteria
    {
        public const decimal CostoRilegatura = 1.80m;
        public const decimal CostoPocheFotocopie = 0.10m;
        public const decimal CostoMedioFotocopie = 0.08m;
        public const decimal CostoTanteFotocopie = 0.05m;

        internal static bool Menu()
        {
            bool continua = true;
            int scelta;
            string nome = "";
            string cognome = "";
            bool rilegatura = false;
            int numeroFotocopie = 0;
            decimal preventivo = 0.0m;
            PrintMenu();
            scelta = VerificaInputIntero();
            switch (scelta)
            {
                case 0:
                    Console.WriteLine("A presto");
                    continua = false;
                    return continua;
                case 1:
                    InserisciValori(ref nome, ref cognome, ref rilegatura);
                    break;
                case 2:
                    Console.WriteLine("Inserire il numero di fotocopie da eseguire");
                    numeroFotocopie = VerificaInputIntero();
                    preventivo = CalcolaPreventivo(numeroFotocopie, rilegatura);
                    break;
                case 3:
                    PrintPreventivo(nome, cognome, rilegatura, preventivo);
                    break;
                default:
                    Console.WriteLine("Inserisci un valore corretto");
                    scelta = VerificaInputIntero();
                    break;
            }
            return continua;
        }

        public static void PrintPreventivo(string nome, string cognome, bool rilegatura, decimal preventivo)
        {
            Console.WriteLine($"Gentile Sig. {nome} {cognome}");
            Console.WriteLine($"il suo preventivo è di {preventivo} euro");
            if (rilegatura)
            {
                Console.WriteLine("compresa la rilegatura");
            }
        }

        public static decimal CalcolaPreventivo(int numeroFotocopie, bool rilegatura)
        {
            decimal result = rilegatura ? CostoRilegatura : 0.0m;
            //if(rilegatura == true)
            //{
            //    result = CostoRilegatura;
            //}else
            //{
            //    result = 0.0m;
            //}
            if(numeroFotocopie > 1 && numeroFotocopie < 20)
            {
                result += numeroFotocopie * CostoPocheFotocopie;
            } else if(numeroFotocopie >= 20 && numeroFotocopie < 100)
            {
                result += numeroFotocopie * CostoMedioFotocopie;
            }
            else
            {
                result += numeroFotocopie * CostoTanteFotocopie;
            }
            return result;
        }

        public static void InserisciValori(ref string nome, ref string cognome, ref bool rilegatura)
        {
            Console.WriteLine("Inserisci i tuoi dati");
            nome = InsertData("nome");
            cognome = InsertData("cognome");
            Console.WriteLine("Vuoi inserire anche la rilegatura?");
            rilegatura = ConfermaRilegatura();
        }

        public static bool ConfermaRilegatura()
        {
            Console.WriteLine("Inserisci 0 per rifiutare qualsiasi altro numero per confermare");
            int sceltaRilegatura = VerificaInputIntero();
            //if(sceltaRilegatura == 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return sceltaRilegatura == 0 ? false : true;
        }

        //public static bool ConfermaRilegatura2()
        //{
        //    Boolean.TryParse(Console.ReadLine(), out bool result);
        //    return result;
        //}

        public static string InsertData(string valoreDaInserire)
        {
            Console.Write($"Inserire {valoreDaInserire}:");
            string info = Console.ReadLine();
            return info;
        }

        public static void PrintMenu()
        {
            Console.WriteLine("-- Copisteria --");
            Console.WriteLine("1. Inserisci i dati dell'utente");
            Console.WriteLine("2. Stampa fotocopie");
            Console.WriteLine("3. Stampa preventivo");
            Console.WriteLine("0. Esci");
        }

        public static int VerificaInputIntero()
        {
            int valoreIntero;
            Console.Write("Inserisci ->");
            bool valid = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            while(!valid || valoreIntero < 0)
            {
                Console.Write("Inserisci ->");
                valid = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            }
            return valoreIntero;
        }

    }
}
