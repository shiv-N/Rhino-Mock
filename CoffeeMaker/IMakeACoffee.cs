using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMakerRhinoMoq
{
    public interface IMakeACoffee
    {
        bool CheckIngridentAvalability();

        string CoffeeMaking(int suggerPerSpone, int CoffeePack);
    }
}
