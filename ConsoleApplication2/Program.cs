using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            // vytvořil Petr Špryňar
            // jestli mi to čorneš tak nejsi moc frajer no
            Console.Title = "Beta Kalkulačka";
        Start:
            Console.WriteLine("Vítejte v Beta Kalkulačce");
            string beta = @"
_____________________________________   
\______   \_   _____/\__    ___/  _  \  
 |    |  _/|    __)_   |    | /  /_\  \ 
 |    |   \|        \  |    |/    |    \
 |______  /_______  /  |____|\____|__  /
        \/        \/                 \/";
            Console.WriteLine(beta);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Stisknutím tlačítka ve hranaté závorce zvolte jednu z možností");
            Console.WriteLine("");
            Console.WriteLine("[A] Výpočet obvodu a obsahu čtverce              [C] Výpočet obvodu a obsahu kruhu");
            Console.WriteLine("[B] Výpočet obvodu a obsahu obdélníku            [D] Výpočet obvodu a obsahu trojúhelníku");
            Console.WriteLine("[Mezerník] Ukončit program");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.A)
            {
                Console.Clear();
                Console.WriteLine("Zapište délku strany vašeho čtverce");
            Ctverec:
                string strana1;
                double strana10, obvod1, obsah1;
                strana10 = obvod1 = obsah1 = 0;
                strana1 = null;
                strana1 = Console.ReadLine();
                if(double.TryParse(strana1, out strana10) && strana10 != 0)
                {
                    obvod1 = strana10 * 4;
                    obsah1 = Math.Pow(strana10, 2);
                    Console.Clear(); // vyčištění konzole
                    Console.WriteLine("Obvod vašeho čtverce : {0}", obvod1); // zde se ukáže vypočtený obvod
                    Console.WriteLine("Obsah vašeho čtverce : {0}", obsah1); // zde se ukáže vypočtený obsah
                    Console.WriteLine("Pokračujte stisknutím libovolného tlačítka.");
                    Console.ReadLine();
                    Console.Clear();
                SpatneCtverec: // sem mě pošle goto Spatne
                    Console.WriteLine("Chcete počítat ještě s dalším čtvercem [A/N]");
                    ConsoleKeyInfo tlacitko = Console.ReadKey(); // přečtení tlačítka, které uživatel zadá
                    if (tlacitko.Key == ConsoleKey.A) // pokud zadá "A"
                    {
                        Console.Clear();
                        goto Ctverec; // pošle mě do Start:
                    }
                    else if (tlacitko.Key == ConsoleKey.N) // pokud zadá "N"
                    {
                        Console.Clear();
                        goto Start;
                    }
                    else // když je blbec
                    {
                        goto SpatneCtverec; // pošle mě do Spatne:
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Nebylo zadáno číslo.");
                    Console.WriteLine("Zkuste to prosím znovu.");
                    goto Ctverec; // pošle mě do Start:
                }
            }
            else if (cki.Key == ConsoleKey.B)
            {
                Console.Clear();
            Obdelnik:
                string strana1, strana2;
                double strana10, strana20, obvod1, obsah1;
                strana10 = strana20 = obvod1 = obsah1 = 0;
                strana1 = null;
                Console.WriteLine("Zapište délku jedné strany vašeho obdélníku");
                strana1 = Console.ReadLine();
                Console.WriteLine("Zapište délku druhé strany vašeho obdélníku");
                strana2 = Console.ReadLine();
                if(double.TryParse(strana1, out strana10) && double.TryParse(strana2, out strana20) && strana10 != 0 && strana20 != 0)
                {
                    obvod1 = strana10 * 2 + strana20 * 2;
                    obsah1 = strana10 * strana20;
                    Console.Clear(); // vyčištění konzole
                    Console.WriteLine("Obvod vašeho obdélníka : {0}", obvod1); // zde se ukáže vypočtený obvod
                    Console.WriteLine("Obsah vašeho obdélníka : {0}", obsah1); // zde se ukáže vypočtený obsah
                    Console.WriteLine("Pokračujte stisknutím libovolného tlačítka.");
                    Console.ReadLine();
                    Console.Clear();
                SpatneCtverec: // sem mě pošle goto Spatne
                    Console.WriteLine("Chcete počítat ještě s dalším obdélníkem? [A/N]");
                    ConsoleKeyInfo tlacitko = Console.ReadKey(); // přečtení tlačítka, které uživatel zadá
                    if (tlacitko.Key == ConsoleKey.A) // pokud zadá "A"
                    {
                        Console.Clear();
                        goto Obdelnik; // pošle mě do Start:
                    }
                    else if (tlacitko.Key == ConsoleKey.N) // pokud zadá "N"
                    {
                        Console.Clear();
                        goto Start;
                    }
                    else // když je blbec
                    {
                        goto SpatneCtverec; // pošle mě do Spatne:
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Jedno z čísel bylo zadáno špatně.");
                    Console.WriteLine("Zkuste to prosím znovu.");
                    goto Obdelnik; // pošle mě do Start:
                }
            }

            else if (cki.Key == ConsoleKey.C)
            {
                Console.Clear();
                Console.WriteLine("Zadejte poloměr vašeho kruhu");
            Kruznice: // sem mě pošle goto Start
                double r, perimeter, area; // určení proměnných
                string polomer;
                r = perimeter = area = 0; // vynulování proměnných
                polomer = null; // odstranění hodnoty proměnné
                polomer = Console.ReadLine(); // uživatel zadá číslo
                if (double.TryParse(polomer, out r) && r != 0) // je zadaný text číslo?
                {
                    perimeter = 2 * 3.14 * r; // výpočet obvodu
                    area = 3.14 * Math.Pow(r, 2); //výpočet obsahu
                    Console.Clear(); // vyčištění konzole
                    Console.WriteLine("Obvod vašeho kruhu : {0}", perimeter); // zde se ukáže vypočtený obvod
                    Console.WriteLine("Obsah vašeho kruhu : {0}", area); // zde se ukáže vypočtený obsah
                    Console.WriteLine("Pokračujte stisknutím libovolného tlačítka.");
                    Console.ReadLine();
                    Console.Clear();
                Spatne: // sem mě pošle goto Spatne
                    Console.WriteLine("Chcete počítat ještě s dalším kruhem? [A/N]");
                    ConsoleKeyInfo tlacitko = Console.ReadKey(); // přečtení tlačítka, které uživatel zadá
                    if (tlacitko.Key == ConsoleKey.A) // pokud zadá "A"
                    {
                        Console.Clear();
                        goto Kruznice; // pošle mě do Start:
                    }
                    else if (tlacitko.Key == ConsoleKey.N) // pokud zadá "N"
                    {
                        Console.Clear();
                        goto Start;
                    }
                    else // když je blbec
                    {
                        goto Spatne; // pošle mě do Spatne:
                    }
                }
                else // pokud není číslo
                {
                    Console.Clear();
                    Console.WriteLine("Nebylo zadáno číslo.");
                    Console.WriteLine("Zkuste to prosím znovu.");
                    goto Kruznice; // pošle mě do Start:
                }
            }
            else if (cki.Key == ConsoleKey.D)
            {
            Trojuhelnik:
                Console.Clear();
                Console.WriteLine("Chcete počítat obvod nebo obsah vašeho trojúhelníku?");
                Console.WriteLine("");
                Console.WriteLine("[A] Obsah");
                Console.WriteLine("[B] Obvod");
                ConsoleKeyInfo tlacitko = Console.ReadKey();
                if(tlacitko.Key == ConsoleKey.A)
                {
                    string strana1, vyska1;
                    double strana10, vyska10, obsah1;
                    strana1 = vyska1 = null;
                    strana10 = vyska10 = obsah1 = 0;
                    Console.Clear();
                    Console.WriteLine("Zapište délku jedné ze stran vašeho trojúhelníku");
                    strana1 = Console.ReadLine();
                    Console.WriteLine("Zapište výšku té stejné strany vašeho trojúhelníku");
                    vyska1 = Console.ReadLine();
                    if (double.TryParse(strana1, out strana10) && double.TryParse(vyska1, out vyska10) && vyska10 != 0 && strana10 != 0)
                    {
                        obsah1 = strana10 * vyska10 / 2;
                        Console.Clear(); // vyčištění konzole
                        Console.WriteLine("Obsah vašeho trojúhelníku : {0}", obsah1); // zde se ukáže vypočtený obsah
                        Console.WriteLine("Pokračujte stisknutím libovolného tlačítka.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Chcete počítat ještě s dalším trojúhelníkem? [A/N]");
                        ConsoleKeyInfo tlacitko2 = Console.ReadKey(); // přečtení tlačítka, které uživatel zadá
                        if (tlacitko2.Key == ConsoleKey.A) // pokud zadá "A"
                        {
                            Console.Clear();
                            goto Trojuhelnik; // pošle mě do Start:
                        }
                        else if (tlacitko2.Key == ConsoleKey.N) // pokud zadá "N"
                        {
                            Console.Clear();
                            goto Start;
                        }
                        else // když je blbec
                        {

                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Jedno z čísel bylo zadáno špatně.");
                        Console.WriteLine("Zkuste to prosím znovu.");
                        goto Trojuhelnik; // pošle mě do Start:
                    }
                }
                else if(tlacitko.Key == ConsoleKey.B)
                {
                    string strana1, strana2, strana3;
                    double strana10, strana20, strana30, obvod1;
                    strana1 = strana2 = strana3 = null;
                    strana10 = strana20 = strana30 = obvod1 = 0;
                    Console.Clear();
                    Console.WriteLine("Zapište délku jedné strany vašeho trojúhelníku");
                    strana1 = Console.ReadLine();
                    Console.WriteLine("Zapište délku druhé strany vašeho trojúhelníku");
                    strana2 = Console.ReadLine();
                    Console.WriteLine("Zapište délku třetí strany vašeho trojúhelníku");
                    strana3 = Console.ReadLine();
                    if (double.TryParse(strana1, out strana10) && double.TryParse(strana2, out strana20) && double.TryParse(strana3, out strana30) && strana10 != 0 && strana20 != 0 && strana30 != 0)
                    {
                        obvod1 = strana10 + strana20 + strana30;
                        Console.Clear(); // vyčištění konzole
                        Console.WriteLine("Obvod vašeho trojúhelníku : {0}", obvod1); // zde se ukáže vypočtený obsah
                        Console.WriteLine("Pokračujte stisknutím libovolného tlačítka.");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Chcete počítat ještě s dalším trojúhelníkem? [A/N]");
                        ConsoleKeyInfo tlacitko2 = Console.ReadKey(); // přečtení tlačítka, které uživatel zadá
                        if (tlacitko2.Key == ConsoleKey.A) // pokud zadá "A"
                        {
                            Console.Clear();
                            goto Trojuhelnik; // pošle mě do Start:
                        }
                        else if (tlacitko2.Key == ConsoleKey.N) // pokud zadá "N"
                        {
                            Console.Clear();
                            goto Start;
                        }
                        else // když je blbec
                        {

                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Jedno z čísel bylo zadáno špatně.");
                        Console.WriteLine("Zkuste to prosím znovu.");
                        goto Trojuhelnik; // pošle mě do Start:
                    }
                }
                else
                {
                    Console.Clear();
                    goto Start;
                }
            }
            else if (cki.Key == ConsoleKey.Spacebar)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                goto Start; // pošle mě do Start:
            }   
            }
        }
    }
