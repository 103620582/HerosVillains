using System;

namespace GameAPI
{
    public class Villain
    {
        public int VillainId { get; set; }
        public string VillainName { get; set; }
        public int HitPoints { get; set; }

        public Villain (int villainId, string villainName, int hitPoints) {
            this.VillainId = villainId;
            this.VillainName = villainName;
            this.HitPoints = hitPoints;
        }

        public Villain()
        {
        }
    }
}