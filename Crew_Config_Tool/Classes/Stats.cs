namespace FS_Crew_Config_Tool
{
    public class Stats
    {
        public enum BALANCE
        {
            MIN,
            MID,
            MAX
        }

        // CAG
        public float SquadCoolDown = 0;
        public float SquadSurvival = 0;

        public const float CAG_MAX = 15f;
        public const float CAG_MID = 11.25f;
        public const float CAG_MIN = 7.5f;

        /// <summary>
        /// Sets CAG stats
        /// </summary>
        /// <param name="squadCdState">MIN - sets MIN to CD, MAX to Survival</param>
        public void SetCagStats(BALANCE squadCdState)
        {
            switch (squadCdState)
            {
                case BALANCE.MIN:
                {
                    SquadCoolDown = CAG_MAX;
                    SquadSurvival = CAG_MIN;
                    break;
                }
                case BALANCE.MID:
                {
                    SquadCoolDown = CAG_MID;
                    SquadSurvival = CAG_MID;
                    break;
                }
                case BALANCE.MAX:
                {
                    SquadCoolDown = CAG_MIN;
                    SquadSurvival = CAG_MAX;
                    break;
                }
            }
        }


        // CAPTAIN
        public float AttackDamage = 0;
        public float CaptureRate = 0;
        public float DamageReduction = 0;

        public const float CAPT_DAMAGE_1 = 1;
        public const float CAPT_DAMAGE_2 = 2;
        public const float CAPT_DAMAGE_3 = 3;
        public const float CAPT_DAMAGE_4 = 4;

        public const float CAPT_CAPTURE_LVL_1 = 6.25f;
        public const float CAPT_CAPTURE_LVL_2 = 12.5f;
        public const float CAPT_CAPTURE_LVL_3 = 18.75f;
        public const float CAPT_CAPTURE_LVL_4 = 25;

        public const float CAPT_DMG_RED_LVL_1 = 1.25f;
        public const float CAPT_DMG_RED_LVL_2 = 2.5f;
        public const float CAPT_DMG_RED_LVL_3 = 3.75f;
        public const float CAPT_DMG_RED_LVL_4 = 5;


        // COMMS
        public float EnergyRegen = 0;
        public float SensorRange = 0;

        public const float COMMS_ENERGY_REGEN_LVL_1 = 3.75f;
        public const float COMMS_ENERGY_REGEN_LVL_2 = 5.63f;
        public const float COMMS_ENERGY_REGEN_LVL_3 = 7.5f;

        public const float COMMS_SENSOR_RANGE_LVL_1 = 8f;
        public const float COMMS_SENSOR_RANGE_LVL_2 = 12;
        public const float COMMS_SENSOR_RANGE_LVL_3 = 16;

        // ENGINEER
        

    }
}
