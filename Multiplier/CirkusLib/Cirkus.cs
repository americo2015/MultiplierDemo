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

        public Cirkus(string cirkusName)
        {
            this.cirkusName = cirkusName;
        }
        
        public void Anställ(Artist clown)
        {
            throw new NotImplementedException();
        }

        public void ArtistUppträdande(Artist clown)
        {
            throw new NotImplementedException();
        }
        
    }
}
