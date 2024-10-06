using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApp3
{
        class Program
        {
            static void Main()
            {
            Guestbook guestbook = new Guestbook();
                int i;

                while (true)
                {
                    Console.Clear(); // rensar skärmen
                Console.CursorVisible = false; // gömmer markören
                Console.WriteLine("J o n a s   G ä s t b o k\n\n"); // skriver ut rubrik

                Console.WriteLine("1. Skriv i gästboken"); // skriver ut menyval
                Console.WriteLine("2. Ta bort inlägg\n");
                    Console.WriteLine("X. Avsluta\n");

                    i = 0; // räknare för att skriva ut index
                foreach (GuestbookEntry guestbookText in guestbook.GetGuestbookEntries()) // loopar igenom alla inlägg i gästboken
                { 
                        Console.WriteLine("[" + i++ + "] " + guestbookText.Name + " - " + guestbookText.Comment); // skriver ut inlägg. Namn följt av kommentar med " - " emellan
                }
                int? inp = null; // sätter inmatning till null
                var key = Console.ReadKey(true).Key; // läser in knapptryck

                if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2) // om knapptryck är 2 eller NumPad2
                {
                    inp = 2;// sätt inmatning till talet 2
                }

                else if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1) // om knapptryck är 1 eller NumPad1
                {
                    inp = 1; // sätt inmatning till talet 1
                }

                else
                {
                    inp = (int)key; // annars sätt inmatning till tangenttalet från knapptrycket
                }

                switch (inp) // switch för att välja vad som ska hända beroende på inmatning
                {
                    case 1: // om inmatning är 1
                        string? name = ""; // sätt namn till tom sträng

                        while (string.IsNullOrEmpty(name) || name.Length < 1) // så länge namn är tomt eller mindre än 1 tecken

                        {
                            Console.CursorVisible = true; // visa markören
                            Console.Clear(); // rensa skärmen
                            Console.Write("Ange ditt namn: "); // skriv ut fråga
                            name = Console.ReadLine(); // läs in namn

                            if (String.IsNullOrEmpty(name) || name.Length < 1) // om namn är tomt eller mindre än 1 tecken så skriv ut felmeddelande
                            {
                                Console.WriteLine("Du måste ange ditt namn!\n"); // skriv ut felmeddelande
                                Console.WriteLine("Tryck på valfri knapp för att försöka igen..."); // skriv ut instruktion för att försöka igen

                                Console.ReadKey(); // läs in knapptryck för att komma vidare

                            }
                        }
                        string? comment = ""; // sätt kommentar till tom sträng


                        while (string.IsNullOrEmpty(comment) || comment.Length < 1)
                        { // så länge kommentar är tomt eller mindre än 1 tecken så fråga efter kommentar

                            Console.Write("Ange din kommentar: "); // skriv ut fråga
                            comment = Console.ReadLine(); // läs in kommentar

                            if (String.IsNullOrEmpty(comment) || comment.Length < 1) // om kommentar är tomt eller mindre än 1 tecken så skriv ut felmeddelande
                            {
                            Console.WriteLine("Du måste skriva en kommentar!\n"); // skriv ut felmeddelande
                                Console.WriteLine("Tryck på valfri knapp för att försöka igen..."); // skriv ut instruktion för att försöka igen
                                Console.ReadKey(); // läs in knapptryck för att komma vidare
                                Console.Clear(); // rensa skärmen
                                Console.WriteLine("Ditt namn: " + name + "\n"); // skriv ut redan inmatad data, dvs namn följt av :
                            }
                }

                        guestbook.AddGuestbookEntry(name,comment); // lägg till det godkända inlägget i gästboken
                        break; // bryt switch-satsen
                    case 2:
                            Console.CursorVisible = true; // visa markören
                        Console.Write("\nAnge index att radera: "); // skriv ut fråga
                        string? index = Console.ReadLine(); // läs in index
                        if (!String.IsNullOrEmpty(index)) // om index inte är tomt så försök ta bort inlägg
                            try
                                {
                                    guestbook.DelEntry(Convert.ToInt32(index)); // försök ta bort inlägg
                            }
                                catch (Exception) // om det inte går att ta bort inlägg så skriv ut felmeddelande
                            {
                                    Console.WriteLine("\n\nNu försökte du ta bort någonting som inte fanns!\n\nTryck på valfri knapp för att komma tillbaka till menyn...");
                                    Console.ReadKey(); // läs in knapptryck för att komma vidare
                                Console.Clear();     // rensa skärmen
                            }
                            break; // bryt switch-satsen
                    case 88: // om inmatning är 88 (dvs X)
                        Environment.Exit(0); // avsluta programmet
                        break; // bryt switch-satsen
                }

                }

            }
        }
    }

// koden bygger mycket på exempelet från föreläsningen