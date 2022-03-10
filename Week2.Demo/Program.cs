using System;
using System.Collections;
using System.Diagnostics;

namespace Week2.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DEMO INIZIALE
            //Console.WriteLine("Hello World!");
            //int x = 0;
            //MyMethod(2, 3, ref x);
            //MyMethod(2, 3, x);
            //Console.WriteLine($"La x vale: {x}");
            //Console.WriteLine("La x vale: " + x);
            //Console.WriteLine("La x vale: {0}", x);
            //x = SommaValori(2, 3);
            #endregion

            #region FIBONACCI
            //int risultatoIterativo = Fibonacci.FibonacciIterativo(5);
            ////Console.WriteLine($"Il valore richiesto è: {risultatoIterativo}");
            ////int risultatoRicorsivo = Fibonacci.FibonacciRicorsivo(5);
            ////Console.WriteLine($"Il valore ottenuto con la ricorsione è: {risultatoRicorsivo}");

            //Stopwatch watch = new Stopwatch();
            //watch.Start(); //faccio partire il cronometro
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine($"Numero {i} della serie di " +
            //        $"Fibonacci Iterativo: {Fibonacci.FibonacciIterativo(i)} ");
            //}
            //watch.Stop();
            //Console.WriteLine($"Tempo impiegato {watch.ElapsedMilliseconds}");

            //Stopwatch watchRicorsivo = new Stopwatch();
            //watchRicorsivo.Start();
            //for (int i = 0; i < 50; i++)
            //{
            //    Console.WriteLine($"Numero {i} della serie di " +
            //        $"Fibonacci Ricorsivo: {Fibonacci.FibonacciRicorsivo(i)}");
            //}
            //watchRicorsivo.Stop();
            //Console.WriteLine("Tempo impiegato {0}", watchRicorsivo.ElapsedMilliseconds);
            #endregion

            #region ARRAY E ARRAYLIST
            //int[] array = new int[50];// { 1, 2, 3};
            //int[] array2 = new int[] { 1, 2, 3 };
            ////0 ... N-1
            //array[0] = 10;
            //array[49] = 100;
            ////Errore semantico ma non sintattico
            ////array[50] = 200;
            ////Console.WriteLine(array[50]);

            //double[] arrayDiDouble = new double[] { 1.3, 2.3, 5.6 };
            //for(int i = 0; i < arrayDiDouble.Length; i++)
            //{
            //    Console.WriteLine(arrayDiDouble[i]);
            //}

            //int indicePrimoValore = Array.IndexOf(arrayDiDouble, 5.6);
            //Console.WriteLine("Il valore 5.6 si trova in posizione {0}", indicePrimoValore);

            //int[] arrayVuoto = new int[] { };
            //if(arrayVuoto.Length == 0)
            //{
            //    Console.WriteLine("Questo array è vuoto");
            //}

            //string nome = "Antonia";
            //Console.WriteLine(nome[0]);
            //int lunghezza = nome.Length;
            //nome = "Antonia Sacchitella";
            //foreach(double value in arrayDiDouble)
            //{
            //    Console.WriteLine(value);
            //}
            //Array.Resize(ref arrayDiDouble, 20);
            //Console.WriteLine(arrayDiDouble.Length);

            ////Dichiarazione ArrayList
            //ArrayList esempio = new ArrayList(); //Lista vuota 
            //ArrayList esempioMisto = new ArrayList() { 1, "ciao", 4.5, true };
            //Console.WriteLine(esempioMisto[0]);
            //esempioMisto.Add(new DateTime());
            //esempioMisto.Add(45); //aggiunta in coda di un elemento
            //for(int i = 0; i < esempioMisto.Count; i++)
            //{
            //    Console.WriteLine("Elemento in posizione {0}: {1}", i, esempioMisto[i]);
            //}
            //foreach(var value in esempioMisto)
            //{
            //    Console.WriteLine(value);
            //}
            //esempioMisto.RemoveAt(0); //rimozione elemento in prima posizione
            //esempioMisto.RemoveAt(esempioMisto.Count - 1); //rimozione in ultima posizione
            //esempioMisto.AddRange(arrayDiDouble); //inserimento massivo dell'array
            //esempioMisto.RemoveRange(0, 3);
            //esempioMisto.Add(true);
            //esempioMisto.Remove(true);
            //Console.WriteLine("Stampa dopo una serie di modifiche");
            //foreach (var value in esempioMisto)
            //{
            //    Console.WriteLine(value);
            //}
            #endregion

            #region CLASSI E OGGETTI
            //Istanzio oggetto di tipo persona
            //Persona persona = new Persona();

            //persona.Nome = "Mario"; //uso il set per settare _nome
            //persona.DataNascita = new DateTime(1980, 1, 1);
            //Console.WriteLine($"Nome: {persona.Nome} - Età: {persona.Eta}");

            //persona.Password = "12345";
            //// Console.WriteLine("La tua password è {0}", persona.Password);
            //// non è possibile eseguire questa operazione perchè write only
            //Console.Write("Inserisci password: ");
            //string password = Console.ReadLine();
            //if (persona.ValidaPassword(password))
            //{
            //    Console.WriteLine("Password corretta");
            //}
            //else
            //{
            //    Console.WriteLine("Password errata");
            //}

            //Persona p = new Persona();
            //Console.WriteLine(p.Nome);
            //Console.WriteLine(p.DataNascita);
            //p.Nome = "Marco";
            //Console.WriteLine(p.Nome);

            //Persona personaNonDefault = new Persona()
            //{
            //    Nome = "Antonia",
            //    DataNascita = new DateTime(1993, 3, 2),
            //    Password = "ppppp",
            //};

            //Console.WriteLine(Persona.Codice);
            #endregion

            #region GESTIONE INPUT/OUTPUT
            ArrayList persone = new ArrayList();
            Persona persona1 = new Persona()
            {
                Nome = "Mario Rossi",
                DataNascita = new DateTime(1988, 2, 5),
                Password = "12345"
            };
            Persona persona2 = new Persona()
            {
                Nome = "Luca Bianchi",
                DataNascita = new DateTime(1955, 3, 4),
                Password = "5678"
            };
            persone.Add(persona1);
            persone.Add(persona2);

            GestioneIO.StampaPersoneSuFile(persone);

            persone = GestioneIO.CaricaPersoneDaFile();

            foreach(Persona persona in persone)
            {
                Console.WriteLine(persona);
            }

            
            
            #endregion


        }

        public static void MyMethod(int a, int b, ref int c)
        //public static void MyMethod(int a, int b, int c)
        {
            c = a + b;
        }
        public static int MyMethod(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public static int SommaValori(int a, int b)
        {
            return a + b;
        }
    }
}
