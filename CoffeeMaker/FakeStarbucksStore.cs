using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerRhinoMoq
{
    public class FakeStarbucksStore : IMakeACoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }

        public string CoffeeMaking(int suggerPerSpone, int CoffeePack)
        {
            return "Your Order is received.";
        }
    }
}
