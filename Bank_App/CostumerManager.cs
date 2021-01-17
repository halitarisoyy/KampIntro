using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_App
{
    class CostumerManager
    {
        public void Entrance(Costumer costum)
        {
            Console.WriteLine(costum.NameLastname+" hoş geldiniz.\n"+"Müşteri İd:     "+costum.Id+"\nAdres:          "+costum.Adress+"\nHesap bakiyesi: "+costum.Amount+"TL");
        }
        
        
        
    }
}
