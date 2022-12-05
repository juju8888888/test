using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Mot_meles_Odoni_LeGall
{
    class Dictionnaire
    {
        private string langue;
        private SortedList<int, List<string>> mots;
        public Dictionnaire(string Langue, string Mots)
        {
            this.langue = Langue;
           
            
        }
        public void Readfile(string mots)
        {
            StreamReader flux = null;
            string line;
            int i = 1;
            char[] separateur = { ';' };
            List<string> mem = new List<string>();
            try
            {
                flux = new StreamReader(mots);
                while ((line = flux.ReadLine()) != null)   //??
                {
                    string[] s = line.Split(separateur);

                    if (s.Length == 1 && i == 1)
                    {
                        i++;
                    }
                    else
                    {
                        mem.Add(s);
                        i++;
                        if (s.Length == 1)
                        {
                            this.mots.Add(s.Length, mem);
                        }
                    }

                }
           
            }
            catch(FileNotFoundException f)
            {
                Console.WriteLine("probleme ReadFile : " + f.Message);
            }
            finally
            {
                if(mots != null)
                {
                    flux.Close();
                }

            }
        }

        public override string ToString()
        {
            string dictionaire = "";
            for (int i=0; i<mots.Keys.Count; i++)
            {
                int nb = 0;
                for(int j=0; j<mots.Values.Count; j++)
                {
                    nb++;
                }
                dictionaire += "Il y a " + nb + " mots de " + (i+1);
            }
            return "Le dictionnaire est en " + this.langue + dictionaire;
        }

    }
}
