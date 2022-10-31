using System;

namespace RoleplayGame.Items
{
    public class EscudoMagico : IDefenseItem
    {
        EscudoMedieval escudoMedieval = new EscudoMedieval();
        GemaMagicaDefensa gemaMagicaDefensa = new GemaMagicaDefensa();
        public int DefensePower
        {
            get
            {
                return escudoMedieval.DefensePower + gemaMagicaDefensa.DefensePower;
            }
        }
    }
}