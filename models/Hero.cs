using System;

namespace GameAPI
{
    public class Hero
    {
        public int HeroId { get; set; }
        public string HeroName { get; set; }
        public int DiceMin { get; set; }
        public int DiceMax { get; set; }
        public int UsesLeft { get; set; }

        public Hero (int heroId, string heroName, int diceMin, int diceMax, int usesLeft) {
            this.HeroId = heroId;
            this.HeroName = heroName;
            this.DiceMin = diceMin;
            this.DiceMax = diceMax;
            this.UsesLeft = usesLeft;
        }

        public Hero()
        {
        }
    }
}