/*********************************************
		*
* Projet genere avec CSProjectCreator v:1.01b
		*
*  Module:  Comparateur2Salaire_20220119_00145
* Developpe par Patrice Waechter-Ebling 2022
		*********************************************/
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	namespace Comparateur2Salaire_20220119_00145{	    internal class Program  {
	        static void Main(string[] args){
//Votre segment de code  a �t� ins�r� ici
        Console.Title="Calculateur de progression pour Investissement";
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Programme d�veloppp� dans le cadre de l'AEC!\nBase sur un taux fixe\n\nEntrez le montant du salaire initial fourni par la 1�re compagnie ");
        capital=Convert.ToDouble(Console.ReadLine());
        Console.Write("Entrez le montant d'augmentation ");
        taux = Convert.ToDouble(Console.ReadLine());
        Console.Write("Entrez le montant du salaire initial fourni par la 2e compagnie ");
        capital2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Entrez le montant d'augmentation ");
        taux2 = Convert.ToDouble(Console.ReadLine());
        total = capital + taux;
        total2 = capital2 + taux2;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Expansion 1ere ann�e " + total.ToString() + "$ contre " + total2.ToString() + "$");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(total2 - total);
            int nAnnees =1;
        while (total != total2){
            double nCapital = total;
            double nCapital2 = total2;
            total = nCapital + taux;
            total2 = nCapital2 + taux2;
            nAnnees++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Expansion "+nAnnees.ToString()+ "e annee  Compagnie 1: "+ total.ToString()+ "$ Compagnie 2: "+ total2.ToString()+"$");
            if (total > total2) { nAnnees++;Console.ForegroundColor = ConsoleColor.Red;  Console.Write( "Nombre d'annees " + nAnnees.ToString());  return;  }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(total2 - total);
            Console.ForegroundColor = ConsoleColor.White;
            }

		 Console.WriteLine("Appuyez une touche pour quitter");Console.Read(); // informe l'utilisateur de presser une touche pour fermer la console
		}
    }
}
