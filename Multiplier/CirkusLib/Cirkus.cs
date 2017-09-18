using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusLib
{
    public class Cirkus
    {
        private string cirkusName;
        private Dictionary<Artist, int> ArtistFöreställningarDictionary = new Dictionary<Artist, int>();

        public Cirkus(string cirkusName)
        {
            this.cirkusName = cirkusName;
        }

        public int AntalArtist {
            get {
                return this.ArtistFöreställningarDictionary.Count;
            }
        }

        public void Anställ(Artist artist)
        {
            ArtistFöreställningarDictionary.Add(artist, 0);
        }

        public void ArtistUppträdande(Artist artist)
        {
            ArtistFöreställningarDictionary[artist]++;
        }

        public override string ToString()
        {
            var message = $"Cirkusen {this.cirkusName} har {this.AntalArtist} artister.";

            foreach (var artistFörestallningarEntry in ArtistFöreställningarDictionary)
            {
                string gånger = "gång";
                if (artistFörestallningarEntry.Value > 1)
                {
                    gånger += "er";
                }
                message += $" {artistFörestallningarEntry.Key.name} har uppträtt {artistFörestallningarEntry.Value} {gånger}.";
            }

            return message;
        }

    }
}
