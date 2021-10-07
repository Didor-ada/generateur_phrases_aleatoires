using System;
using System.Collections.Generic;

namespace generateur_phrases_aleatoires
{
    class Program
    {
        static void Main(string[] args)
        {

            static string ObtenirElementAleatoire(string[] t)
            {
                Random r = new Random();
                int i = r.Next(t.Length); // quand on donne 1 paramètre à la fonction Next c'est le max : entre 0 et le max d'indexs
                return t[i];
            }


            var sujets = new string[] {
                "Un lapin",
                "Une grand-mère", 
                "Un chat", 
                "Un bonhomme de neige", 
                "Une limace", "Une fée", 
                "Un magicien", 
                "Une tortue", 
            };

            var verbes = new string[]
            {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "nettoie",
                "se bat avec",
                "s'accroche à",
            };

            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };

            const int NB_PHRASES = 100;

            var phrasesUniques = new List<string>();
            int doublonsEvites = 0;
            
            // for (int i = 0; i < NB_PHRASES; i++) -> on va faire un while pour avoir 100 résultats doublons exclus 
            while(phrasesUniques.Count < NB_PHRASES)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);
                var phrase = sujet + " " + verbe + " " + complement;
                phrase = phrase.Replace("à le", "au");

                if (!phrasesUniques.Contains(phrase)) // = si elle ne contient pas la phrase
                {
                    phrasesUniques.Add(phrase);
                }
                else
                {
                    doublonsEvites++;
                }
            }

            foreach(var phrase in phrasesUniques)
            {
                Console.WriteLine(phrase);
            }

            Console.WriteLine();
            Console.WriteLine("Nombre de phrases uniques : " + phrasesUniques.Count);
            Console.WriteLine("Nombre de doublons évités : " + doublonsEvites);

        }
    }
}
