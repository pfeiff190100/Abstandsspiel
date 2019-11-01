using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstandspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int quess1 = 0;
            int quess2 = 0;
            int max_zufallszahl = 0;
            int max_punkteanzahl = 0;
            int points_1 = 0;
            int points_2 = 0;
            int betrag1 = 0;
            int betrag2 = 0;
            string Spielername;
            string name1;
            string name2;
            Console.WriteLine("Willkommen beim Get_Closer Spiel");
            Console.WriteLine("Bei diesem gewinnt der jeweilige Spieler der Zuerst die zuvor festgelegte Zahl überschreitet");
            Console.WriteLine("Es funktioniert so indem immer eine Zufalsszahl zwischen 0 und einer festlegbaren Zahl gezogen wird, Wenn ein Spieler 20 Zahlen von der Zufallszahl entfernt ist bekommt er mehr Punkte als wenn er nur 100 Zahlen enfert ist");
            Console.WriteLine("Ja so funktioniert dieses Spiel und nun startet das Spiel wenn sie Enter drücken");
            Console.WriteLine("moin leude trymacs hier stefan weiß nicht wies geht weil er schlecht und dumm ist und nichts kann schildkröten sind tolle tiere stefan kann das nicht obwohl er das schon voll lang macht das find ich nicht toll paul hat schlechte deutsch schularbeit geschriebne und hat jetzt eine 3");
            string x = Console.ReadLine();

            while (max_punkteanzahl <10 || max_punkteanzahl < 0)
            {
                Console.WriteLine("Bitte legen sie die Punktezahl fest ab der sie Gewonnen haben(minderstens 400)");
                max_punkteanzahl = Convert.ToInt32(Console.ReadLine());
                if (max_punkteanzahl < 10 || max_punkteanzahl < 0)
                {
                    Console.WriteLine("Die Zahl muss größer wie 400 und darf nicht negativ sein!!!! ");
                }
            }

            while (max_zufallszahl < 500 || max_zufallszahl < 0)
            {
                Console.WriteLine("Bitte geben sie die maximale Zufallszahl ein (dort wirdvon 0 bis dieser Zahl gezogen (muss minderstens 500 groß sein))");
                max_zufallszahl = Convert.ToInt32(Console.ReadLine());
                if (max_zufallszahl < 500 || max_zufallszahl < 0)
                {
                    Console.WriteLine("Die Zahl muss größer wie 500 und darf nicht negativ sein!!!!");
                }
            }
            Console.WriteLine("Wollen sie den Spilern einen namen geben (y für ja und jeder andere zahl oder buchtabe für nein");
            Spielername = Console.ReadLine();

            if (Spielername[0] == 'y')
            {
                Console.WriteLine("Bitte geben sie den Namen für Spieler 1 ein");
                name1 = Console.ReadLine(); 

            }




            while (true)

            {
                if (points_1 >= max_punkteanzahl || points_2 >= max_punkteanzahl)
                {

                    Console.WriteLine("Spiel ist aus");
                    if (points_1 > points_2)
                    {
                        Console.WriteLine("Spieler 1 hat gewonnen");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Spieler 2 hat gewonnen");
                        break;

                    }

                }



                Int32 zufalls_zahl = rnd.Next(0, max_zufallszahl);

                    Console.WriteLine("Die Punktezahl des ersten Spielers beträgt {0} von {1}", points_1, max_punkteanzahl);
                    Console.WriteLine("Die Punktezahl des zweiten Spielers beträgt {0} von {1}", points_2, max_punkteanzahl);
                    Console.WriteLine("");
                    Console.WriteLine("");


                Console.WriteLine("Spieler 1 soll bitte seinen Tipp eingeben (Sie muss zwischen 0 und der maximalen zufallszahl liegen)");
                    quess1 = Convert.ToInt32(Console.ReadLine());
                    if (quess1 < 0 || quess1 > max_zufallszahl)
                    {

                        Console.WriteLine("Sie muss zwischen 0 und der maximalen zufallszahl liegen!!!!!!!");
                        Console.WriteLine("Spieler 1 soll bitte seinen Tipp eingeben (Sie muss zwischen 0 und der maximalen zufallszahl liegen)");
                        quess1 = Convert.ToInt32(Console.ReadLine());

                }
                    
                                                     
                
                    Console.WriteLine("Spieler 2 soll bitte seinen Tipp eingeben (Sie muss zwischen 0 und der maximalen zufallszahl liegen)");
                    quess2 = Convert.ToInt32(Console.ReadLine());
                    if (quess2 < 0 || quess2 > max_zufallszahl)
                    {
                        Console.WriteLine("Sie muss zwischen 0 und der maximalen zufallszahl liegen!!!!!!!");
                        Console.WriteLine("Spieler 2 soll bitte seinen Tipp eingeben (Sie muss zwischen 0 und der maximalen zufallszahl liegen)");
                        quess2 = Convert.ToInt32(Console.ReadLine());
                    }
                Console.WriteLine("");
             
                Console.WriteLine("Die zufallszahl die gezogen wurde beträgt {0}", zufalls_zahl);
                


                if (quess1 > zufalls_zahl)
                {
                    betrag1 = quess1 - zufalls_zahl;
                }
                
                if (quess1 < zufalls_zahl)
                {
                    betrag1 = zufalls_zahl - quess1;
                }

                if (quess2 > zufalls_zahl)
                {
                    betrag2 = quess2 - zufalls_zahl;
                }

                if (quess2 < zufalls_zahl)
                {
                    betrag2 = zufalls_zahl - quess2;
                }

                // Spieler 1

                if (betrag1 <= zufalls_zahl && betrag1 >= zufalls_zahl)
                {
                    points_1 = points_1 + 100;
                }

                if (betrag1 >=1 && betrag1 <= 10)
                {
                    points_1 = points_1 + 75;                                                    
                }

                if (betrag1 >= 11 && betrag1 <= 20)
                {
                    points_1 = points_1 + 60;  
                }

                if (betrag1 >= 21 && betrag1 <= 30)
                {
                    points_1 = points_1 + 50;
                }

                if (betrag1 >= 31 && betrag1 <= 40)
                {
                    points_1 = points_1 + 40;
                }

                if (betrag1 >= 41 && betrag1 <= 50)
                {
                    points_1 = points_1 + 30;
                }

                if (betrag1 >= 51 && betrag1 <= 60)
                {
                    points_1 = points_1 + 25;
                }

                if (betrag1 >= 61 && betrag1 <= 70)
                {
                    points_1 = points_1 + 20;
                }

                if (betrag1 >= 71 && betrag1 <= 80)
                {
                    points_1 = points_1 + 18;
                }

                if (betrag1 >= 81 && betrag1 <= 90)
                {
                    points_1 = points_1 + 15;
                }

                if (betrag1 >= 91 && betrag1 <= 100)
                {
                    points_1 = points_1 + 12;
                }

                if (betrag1 >= 101 && betrag1 <= 200)
                {
                    points_1 = points_1 + 10;
                }

                if (betrag1 >= 201 && betrag1 <= 300)
                {
                    points_1 = points_1 + 7;
                }

                if (betrag1 >= 301 && betrag1 <= 400)
                {
                    points_1 = points_1 + 5;
                }

                if (betrag1 >= 401 && betrag1 <= 500)
                {
                    points_1 = points_1 + 3;
                }

                if (betrag1 >= 501 && betrag1 <= 999999999)
                {
                    points_1 = points_1 + 10;
                    Console.WriteLine("Spieler 1, das geht sicher besser oder ;)");
                }

                // Spieler 2

                if (betrag2 <= zufalls_zahl && betrag2 >= zufalls_zahl)
                {
                    points_2 = points_2 + 100;
                }

                if (betrag2 >= 1 && betrag2 <= 10)
                {
                    points_2 = points_2 + 75;
                }

                if (betrag2 >= 11 && betrag2 <= 20)
                {
                    points_2 = points_2 + 60;
                }

                if (betrag2 >= 21 && betrag2 <= 30)
                {
                    points_2 = points_2 + 50;
                }

                if (betrag2 >= 31 && betrag2 <= 40)
                {
                    points_2 = points_2 + 40;
                }

                if (betrag2 >= 41 && betrag2 <= 50)
                {
                    points_2 = points_2 + 30;
                }

                if (betrag2 >= 51 && betrag2 <= 60)
                {
                    points_2 = points_2 + 25;
                }

                if (betrag2 >= 61 && betrag2 <= 70)
                {
                    points_2 = points_2 + 20;
                }

                if (betrag2 >= 71 && betrag2 <= 80)
                {
                    points_2 = points_2 + 18;
                }

                if (betrag2 >= 81 && betrag2 <= 90)
                {
                    points_2 = points_2 + 15;
                }

                if (betrag2 >= 91 && betrag2 <= 100)
                {
                    points_2 = points_2 + 12;
                }

                if (betrag2 >= 101 && betrag2 <= 200)
                {
                    points_2 = points_2 + 10;
                }

                if (betrag2 >= 201 && betrag2 <= 300)
                {
                    points_2 = points_2 + 7;
                }

                if (betrag2 >= 301 && betrag2 <= 400)
                {
                    points_2 = points_2 + 5;
                }

                if (betrag2 >= 401 && betrag2 <= 500)
                {
                    points_2 = points_2 + 3;
                }

                if (betrag2 >= 501 && betrag2 <= 999999999)
                {
                    points_2 = points_2 + 10;
                    Console.WriteLine("Spieler 2, das geht sicher besser oder ;)");
                }



            }




        }
    }
}
