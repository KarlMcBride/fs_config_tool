namespace FS_Crew_Config_Tool
{
    public enum StatCategory
    {
        ATTACK,
        DEFENSE,
        UTILITY
    }

    public enum StatType
    {
        ARMOUR_REPAIR_RATE,
        ARMOUR_STRENGTH,
        ATTACK_DAMAGE,
        BROKEN_ARMOUR_DAMAGE,
        CAPTURE_RATE,
        DAMAGE_REDUCTION,
        ENERGY_EFFICIENCY,
        ENERGY_REGEN,
        FIRE_RATE,
        FORWARD_THRUST,
        HULL_STRENGTH,
        JUMP_COOLDOWN,
        JUMP_DAMAGE_REDUCTION,
        JUMP_PREP,
        MANEUVERING,
        MISSILE_RANGE,
        RAM_DAMAGE,
        REPAIR_EFFICIENCY,
        SENSOR_RANGE,
        STATION_DAMAGE_REDUCTION,
        SQUAD_COOLDOWN,
        SQUAD_SURVIVAL,
        TURN_RATE,
        TURRET_TRAVERSE,
        UTILITY_COOLDOWN,
        UTILITY_DURATION
    }

    public struct Stats
    {
        string Name;

        public float ArmourRepairRate;
        public float ArmourStrength;
        public float AttackDamage;
        public float BrokenArmourDamage;
        public float Capturerate;
        public float DamageReduction;
        public float EnergyEfficiency;
        public float EnergyRegen;
        public float FireRate;
        public float ForwardThrust;
        public float HullStrength;
        public float JumpCooldown;
        public float JumpDamageReduction;
        public float JumpPrep;
        public float Maneuvering;
        public float MissileRange;
        public float RamDamage;
        public float RepairEfficiency;
        public float SensorRange;
        public float StationDamageReduction;
        public float SquadCooldown;
        public float SquadSurvival;
        public float TurnRate;
        public float TurretTraverse;
        public float UtilityCooldown;
        public float UtilityDuration;
    }
}
