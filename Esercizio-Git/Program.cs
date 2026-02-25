using System;
using System.Collections.Generic;

namespace Esericizi_Git
{
    class Program
    {
        // Lista condivisa – tutti gli studenti la useranno
        static List<Studente> registro = new List<Studente>();

        static void Main(string[] args)
        {
            Console.WriteLine("=== REGISTRO STUDENTI - CLASSE 5AI ===");
            Console.WriteLine("Benvenuti! Lavoriamo insieme con Git!\n");

            bool continua = true;
            while (continua)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. Aggiungi studente");
                Console.WriteLine("2. Visualizza tutti gli studenti");
                Console.WriteLine("3. Cerca studente per nome");
                Console.WriteLine("4. Rimuovi studente");
                Console.WriteLine("5. Esci");
                Console.Write("\nScelta: ");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        AggiungiStudente();
                        break;
                    case "2":
                        VisualizzaStudenti_Mencarelli();
                        break;
                    case "3":
                        CercaStudente_Adssaoui();
                        break;
                    case "4":
                        RimuoviStudente();
                        break;
                    case "5":
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Opzione non valida!");
                        break;
                }
            }

            Console.WriteLine("Arrivederci!");
        }

        // =================== METODI DA IMPLEMENTARE DAGLI STUDENTI ===================
        //Aggiungi Studente 
        static void AggiungiStudente()
        {
            string nome;
            string cognome;
            string matricola;
            Console.WriteLine("Insersci nome:");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Insersci cognome:");
            cognome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Insersci matricola:");
            matricola = Convert.ToString(Console.ReadLine());
            registro.Add(new Studente(nome, cognome, matricola));
        }

        // Funzione elaborata da Sofia Mencarelli
        static void VisualizzaStudenti_Mencarelli()
        {
            foreach (var item in registro)
            {
                Console.WriteLine(item.Descrizione());
            }
        }

        static void CercaStudente_Adssaoui()
        {
            Console.WriteLine("Che studente vuoi cercare: ");
            string studente = Console.ReadLine();

            for (int i = 0; i < registro.Count; i++)
            {
                Studente s = registro[i];

                if ((s.Nome + " " + s.Cognome) == studente)
                {
                    Console.WriteLine($"Studente trovato in posizione: {i}");
                    break;
                }
            }

            Console.WriteLine("Studente non trovato.");
        }

        static void RimuoviStudente()
        {
            // DA IMPLEMENTARE dallo studente Y
            Console.WriteLine("Funzione in costruzione...");
        }
    }

    // Classe base – tutti la useranno 
    class Studente
    {
        //Attributi
        string _nome;
        string _cognome;
        string _matricola;

        //Proprietà
        public string Nome { get => _nome; }
        public string Cognome { get => _cognome; }
        public string Matricola { get => _matricola; }

        //Costruttore
        public Studente(string nome, string cognome, string matricola)
        {
            _nome = nome;
            _cognome = cognome;
            _matricola = matricola;
        }

        //Metodo
        public string Descrizione()
        {
            return $"{Matricola} - {Nome} {Cognome}";
        }
    }
}
