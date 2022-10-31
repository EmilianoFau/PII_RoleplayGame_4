namespace RoleplayGame.Items
{
    /// <summary>
    /// Túnica. Permite defenderse levemente.
    /// </summary>
    public class Espada : IDefenseItem, IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 80;
            }
        }

        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 2;
            }
        }

        public override string ToString()
        {
            return "Espada";
        }
    }
}