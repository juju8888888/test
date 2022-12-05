using System;
using System.Collections.Generic;
using System.Text;

namespace Mot_meles_Odoni_LeGall
{
    class Joueur
    {
        private string nom;
        private List<string> mot_trouve;
        private int score;

        public Joueur(string Nom)
        {
            this.nom = Nom;
            this.mot_trouve = new List<string>(); // null dans l'énoncé mais ça ne marche pas.
            this.score = 0;
        }
        public void Add_Mot(string mot)
        {
            mot_trouve.Add(mot);
        } 
        public override string ToString()
        {
            return "nom du joueur : " + this.nom + "\n" + "mots trouvés : " + AfficheList(this.mot_trouve) + "\n" + "score : " + this.score;
        }
        public string AfficheList(List<string> liste)
        {
            int c = 0;
            string mot = "";
            if (liste == null)
            {
                mot = "Le joueur n'a trouvé aucun mot. ";
            }
            else
            {
                foreach (string item in liste)
                {
                    if(liste.Count == 1)
                    {
                        mot = mot + item;
                    }
                    else
                    {             
                        if(liste.Count == c )
                        {
                            mot = mot + item;
                        }
                        else
                        {
                            mot = mot + item + ", ";
                        }
                    }
                    c++; // Compteur.
                }
            }
            return mot;
        }
        public void Add_Score(int val)
        {
            this.score += val;
        }
        /// <summary>
        /// on met le get pour pouvoir lire le nom du joueur.
        /// </summary>
        public string Nom 
        {
            get{return this.nom;}
        }
        public int Score
        {
            get { return this.score; }
        }
        public List<string> Mot_trouve
        {
            get { return this.mot_trouve; }
        }
 


    }
}
