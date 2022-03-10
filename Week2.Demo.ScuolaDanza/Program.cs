using System;

namespace Week2.Demo.ScuolaDanza
{
    //Programma per la gestione delle iscrizioni di una scuola di danza
    //Inserire nome e cognome
    //Visualizzare le quote di iscrizione
    //Scegliere l'abbonamento e visualizzare il costo
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string cognome = "";
            int mesiIscrizione;
            decimal costoTotaleIscrizione;
            int scelta;
            do
            {
                PrintMenu();
                //prendo il valore da console e lo assegno a scelta dopo averlo convertito
                //Int32.TryParse(Console.ReadLine(), out scelta);
                scelta = VerificaInputIntero();
                switch (scelta)
                {
                    case 0:
                        //Esci
                        Console.WriteLine("Arrivederci");
                        break;
                    case 1:
                        //Inserisci i dati (nome e cognome)
                        Console.WriteLine("Inserisci i tuoi dati");
                        //Console.Write("Inserisci nome -> ");
                        //nome = Console.ReadLine();
                        //Console.Write("Inserisci cognome -> ");
                        //cognome = Console.ReadLine();
                        nome = InsertData("nome");
                        cognome = InsertData("cognome");
                        break;
                    case 2:
                        //Console.WriteLine("Il costo del corso di danza è così costituito");
                        //Console.WriteLine("Costo iscrizione: 50 euro");
                        //Console.WriteLine("Abbonamento 4 mesi: 450 euro");
                        //Console.WriteLine("Abbonamento 8 mesi: 400 euro");
                        //Console.WriteLine("Abbonamento annuale: 800 euro");
                        PrintAbbonamenti();
                        break;
                    case 3:
                        //Esegui iscrizione
                        Console.WriteLine("Per quanti mesi vuoi eseguire l'iscrizione?");
                        //Int32.TryParse(Console.ReadLine(), out mesiIscrizione);
                        mesiIscrizione = VerificaInputIntero();
                        //costoTotaleIscrizione = 50.00m;
                        //if(mesiIscrizione == 4)
                        //{
                        //    costoTotaleIscrizione += 450.00m;
                        //    Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotaleIscrizione} euro");
                        //} else if(mesiIscrizione == 8)
                        //{
                        //    costoTotaleIscrizione += 400.00m;
                        //    Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotaleIscrizione} euro");
                        //} else
                        //{
                        //    costoTotaleIscrizione += 800.00m;
                        //    Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotaleIscrizione} euro");
                        //}
                        costoTotaleIscrizione = CalcolaCostoTotale(mesiIscrizione);
                        PrintTotale(nome, cognome, costoTotaleIscrizione);
                        break;
                    default:
                        //Reinserimento della scelta
                        Console.WriteLine("Reinserisci scelta");
                        //Int32.TryParse(Console.ReadLine(), out scelta);
                        scelta = VerificaInputIntero();
                        break;
                }

            } while (scelta != 0);
        }

        public static void PrintMenu()
        {
            Console.WriteLine("=== SCUOLA DI DANZA ===");
            Console.WriteLine("Inserisci l'operazione che vuoi eseguire");
            Console.WriteLine("1. Inserisci i tuoi dati (nome e cognome)");
            Console.WriteLine("2. Visualizzare le quote mensili");
            Console.WriteLine("3. Esegui icrizione");
            Console.WriteLine("0. Esci");
        }

        public static string InsertData(string dato)
        {
            Console.Write($"Inserisci {dato} -> ");
            string info = Console.ReadLine();
            return info;
        }

        public static void PrintAbbonamenti()
        {
            Console.WriteLine("Il costo del corso di danza è così costituito");
            Console.WriteLine("Costo iscrizione: 50 euro");
            Console.WriteLine("Abbonamento 4 mesi: 450 euro");
            Console.WriteLine("Abbonamento 8 mesi: 400 euro");
            Console.WriteLine("Abbonamento annuale: 800 euro");
        }

        public static decimal CalcolaCostoTotale(int mesiIscrizione)
        {
            decimal costoTotaleIscrizione = 50.00m;
            if (mesiIscrizione == 4)
            {
                costoTotaleIscrizione += 450.00m;
                //Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotaleIscrizione} euro");
            }
            else if (mesiIscrizione == 8)
            {
                costoTotaleIscrizione += 400.00m;
                //Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotaleIscrizione} euro");
            }
            else
            {
                costoTotaleIscrizione += 800.00m;
                //Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotaleIscrizione} euro");
            }
            return costoTotaleIscrizione;
        }

        public static void PrintTotale(string nome, string cognome, decimal costoTotale)
        {
            Console.WriteLine($"{nome} - {cognome} pagherai: {costoTotale} euro");
        }

        public static int VerificaInputIntero()
        {
            int valoreIntero;
            
            bool conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            //while(!conversion || valoreIntero < 0)
            while(conversion == false || valoreIntero < 0)
            {
                Console.Write("Valore errato, reinserisci: ");
                conversion = Int32.TryParse(Console.ReadLine(), out valoreIntero);
            }
            return valoreIntero;
        }

    }
}
