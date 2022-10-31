using System;

namespace RoleplayGame.Items
{
    public class Coraza : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 18;
            }
        }
        public override string ToString()
        {
            return "Coraza";
        }
    }
}