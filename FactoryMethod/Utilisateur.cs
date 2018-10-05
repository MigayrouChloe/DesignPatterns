using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Utilisateur
    {
        public void LoadFactory()
        {
            Client client;
            client = new ClientComptant();
            client.NouvelleCommande(1500);
            client.NouvelleCommande(5000);

            client = new ClientCredit();
            client.NouvelleCommande(1500);
            client.NouvelleCommande(6000);
        }
    }
}
