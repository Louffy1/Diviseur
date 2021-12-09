using System;

namespace Laboratoire_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int valeurA = LireValeur("Donnez la première valeur : ");
            int valeurB = LireValeur("Donnez la deuxième valeur : ");
            AfficherLigneTirets();
            int[] diviseurA = TrouverDiviseurs(valeurA);
            int[] diviseurB = TrouverDiviseurs(valeurB);
            int[] communs = TrouverDiviseursCommuns(diviseurA, diviseurB);

            Afficher($"Diviseurs de {valeurA}", diviseurA);
            AfficherLigneTirets();

            Afficher($"Diviseurs de {valeurB}", diviseurB);
            AfficherLigneTirets();

            Afficher($"Diviseurs communs de {valeurA} et {valeurB}", communs);
            AfficherLigneTirets();
        }
        static void Afficher(string texte, int[] valeur)
        {
            int placementTableau;Diviseur et diviseur commun de deux nombres
            Console.WriteLine(texte);
            for (placementTableau = 0; placementTableau < valeur.Length; ++placementTableau)
            {
                Console.Write($"{valeur[placementTableau]} ");
            }
            Console.WriteLine(" ");
        }
        static int LireValeur(string message)
        {
            Console.Write(message);
            int valeur = int.Parse(Console.ReadLine());
            return valeur;
        }
        static void AfficherLigneTirets()
        {
            const int NB_LIGNES = 72;
            for(int nbTiret = 0; nbTiret < NB_LIGNES; ++nbTiret)
            {
                Console.Write("-");
            }
            Console.WriteLine(" ");     
        }
        static int[] TrouverDiviseurs(int valeur)
        {
            int nombreEssai = 1;
            int grosseur = valeur;
            int placement = 0;
            int[] tableauDiviseur;
            tableauDiviseur = new int[grosseur];
            while (nombreEssai < valeur + 1)
            {
                if (valeur % nombreEssai == 0)
                {
                    tableauDiviseur[placement] = nombreEssai;
                    placement = ++placement;
                }
                nombreEssai = ++nombreEssai;
            }
            tableauDiviseur = new int[placement];
            placement = 0;
            nombreEssai = 1;
            while (nombreEssai < valeur + 1)
            {
                if (valeur % nombreEssai == 0)
                {
                    tableauDiviseur[placement] = nombreEssai;
                    placement = ++placement;
                }
                nombreEssai = ++nombreEssai;
            }
            return tableauDiviseur;
        }

        static int[] TrouverDiviseursCommuns(int[] diviseurA, int[] diviseurB)
        {
            int[] tableauDiviseurscommuns;
            int indicePositionA;
            int indicePositionB;
            int indicePositionCommuns = 0;
            int nombrePlaceTableau = 0;
            for (indicePositionB = 0; indicePositionB < diviseurB.Length; ++indicePositionB )
            {
                for (indicePositionA = 0; indicePositionA < diviseurA.Length; ++indicePositionA)
                {
                    if (diviseurA[indicePositionA] == diviseurB[indicePositionB])
                    {
                        nombrePlaceTableau = ++nombrePlaceTableau;
                    }
                }
            }
            tableauDiviseurscommuns = new int[nombrePlaceTableau];

            for (indicePositionB = 0; indicePositionB < diviseurB.Length; ++indicePositionB)
            {
                for (indicePositionA = 0; indicePositionA < diviseurA.Length; ++indicePositionA)
                {
                    if (diviseurA[indicePositionA] == diviseurB[indicePositionB])
                    {
                        tableauDiviseurscommuns[indicePositionCommuns] = diviseurA[indicePositionA];
                        indicePositionCommuns = ++indicePositionCommuns;
                    }
                }
            }
            return tableauDiviseurscommuns;
        }
    }
}