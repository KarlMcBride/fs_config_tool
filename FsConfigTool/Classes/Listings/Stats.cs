using System.Collections.Generic;

namespace FS_Config_Tool.Classes.Listings
{
    /// <summary>
    /// Broad stat category used for grouping (i.e. attack, defense, utility)
    /// </summary>
    public enum StatCategory
    {
        ATTACK,
        DEFENSE,
        UTILITY,
        END_OF_LIST
    }

    /// <summary>
    /// Complete list of stats in-game e.g. attack damage, sensor range
    /// </summary>
    public enum StatEnum
    {
        ARMOUR_REPAIR_RATE,
        ARMOUR_STRENGTH,
        ATTACK_DAMAGE,
        BROKEN_ARMOUR_DAMAGE,
        CAPTURE_RATE,
        DAMAGE_REDUCTION,
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
        SQUAD_COOLDOWN,
        STATION_DAMAGE_REDUCTION,
        SQUAD_SURVIVAL,
        TURN_RATE,
        TURRET_TRAVERSE,
        UTILITY_COOLDOWN,
        UTILITY_DURATION,
        /// <summary>
        /// Listed last as this list is shared for both implants and crew, and is placed last
        /// to ensure that it doesn't impact the implant enumerations and throw off the ordering.
        /// May also be used as an end-of-enum marker for iteration
        /// </summary>
        ENERGY_EFFICIENCY,
        END_OF_LIST
    }

    public struct StatCombination
    {
        /// <summary>
        /// Broad stat category used for grouping (i.e. attack, defense, utility)
        /// </summary>
        public StatCategory Category { get; private set; }
        /// <summary>
        /// Complete list of stats in-game e.g. attack damage, sensor range
        /// </summary>
        public StatEnum Type         { get; private set; }
        /// <summary>
        /// Name of stat shown to the user e.g. "Jump prep"
        /// </summary>
        public string Name           { get; private set; }
        /// <summary>
        /// Quantitative effect of the stat e.g. +200 (hull), -1.5f (util cd)
        /// </summary>
        public float Value           { get; set; }

        /// <summary>
        /// Constructor for stat types
        /// </summary>
        /// <param name="category">Attack/defense/utility</param>
        /// <param name="type">E.g. attack damage, repair efficiency</param>
        /// <param name="name">Stat name e.g. "Capture Rate"</param>
        public StatCombination(StatCategory category, StatEnum type, string name)
        {
            Category = category;
            Type = type;
            Name = name;
            Value = 0;
        }

        /// <summary>
        /// Constructor for implant stats
        /// </summary>
        /// <param name="category">Attack/defense/utility</param>
        /// <param name="type">E.g. attack damage, repair efficiency</param>
        /// <param name="name">Stat name e.g. "Capture Rate"</param>
        /// <param name="value">Implant value e.g. 200 for hull strength</param>
        public StatCombination(StatCategory category, StatEnum type, string name, float value)
        {
            Category = category;
            Type = type;
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Constructor for passing to UI
        /// </summary>
        /// <param name="name">Stat name e.g. "Capture Rate"</param>
        /// <param name="value">Implant value e.g. 200 for hull strength</param>
        public StatCombination(string name, float value)
        {
            Category = StatCategory.END_OF_LIST;
            Type = StatEnum.END_OF_LIST;
            Name = name;
            Value = value;
        }

        public string GenerateFormattedStringForDisplay()
        {
            string formattedString = string.Empty;

            if (Value > 0)
            {
                formattedString = "+";
            }

            formattedString += Value.ToString();

            switch (Type)
            {
                case (StatEnum.HULL_STRENGTH):
                {
                    formattedString += " HP";
                    break;
                }
                default:
                {
                    formattedString += "%";
                    break;
                }
            }

            return formattedString;
        }
    }

    public static class StatList
    {
        public static List<StatCombination> StatsListing;

        public static void PopulateStatsList()
        {
            if (StatsListing != null)
            {
                //return;
            }

            StatsListing = new List<StatCombination>();

            StatCombination armourRepairRate = new StatCombination(StatCategory.DEFENSE, StatEnum.ARMOUR_REPAIR_RATE , "Armour Repair Rate");
            StatsListing.Add(armourRepairRate);

            StatCombination armourStrength = new StatCombination(StatCategory.DEFENSE, StatEnum.ARMOUR_STRENGTH, "Armour Strength");
            StatsListing.Add(armourStrength);

            StatCombination attackDamage = new StatCombination(StatCategory.ATTACK, StatEnum.ATTACK_DAMAGE, "Attack Damage");
            StatsListing.Add(attackDamage);

            StatCombination brokenArmourDamage = new StatCombination(StatCategory.DEFENSE, StatEnum.BROKEN_ARMOUR_DAMAGE, "Broken Armour Damage Reduction");
            StatsListing.Add(brokenArmourDamage);

            StatCombination captureRate = new StatCombination(StatCategory.UTILITY, StatEnum.CAPTURE_RATE, "Capture Rate");
            StatsListing.Add(captureRate);

            StatCombination damageReduction = new StatCombination(StatCategory.DEFENSE, StatEnum.DAMAGE_REDUCTION, "Damage Reduction");
            StatsListing.Add(damageReduction);

            StatCombination energyRegen = new StatCombination(StatCategory.UTILITY, StatEnum.ENERGY_REGEN, "Energy Regen");
            StatsListing.Add(energyRegen);

            StatCombination fireRate = new StatCombination(StatCategory.ATTACK, StatEnum.FIRE_RATE, "Fire Rate");
            StatsListing.Add(fireRate);

            StatCombination forwardThrust = new StatCombination(StatCategory.UTILITY, StatEnum.FORWARD_THRUST, "Forward Thrust");
            StatsListing.Add(forwardThrust);

            StatCombination hullStrength = new StatCombination(StatCategory.DEFENSE, StatEnum.HULL_STRENGTH, "Hull Strength");
            StatsListing.Add(hullStrength);

            StatCombination jumpCooldown = new StatCombination(StatCategory.UTILITY, StatEnum.JUMP_COOLDOWN, "Jump Cooldown");
            StatsListing.Add(jumpCooldown);

            StatCombination jumpDamageReduction = new StatCombination(StatCategory.DEFENSE, StatEnum.JUMP_DAMAGE_REDUCTION, "Jump Damage Reduction");
            StatsListing.Add(jumpDamageReduction);

            StatCombination jumpPrep = new StatCombination(StatCategory.UTILITY, StatEnum.JUMP_PREP, "Jump Prep");
            StatsListing.Add(jumpPrep);

            StatCombination maneuvering = new StatCombination(StatCategory.UTILITY, StatEnum.MANEUVERING, "Maneuvering");
            StatsListing.Add(maneuvering);

            StatCombination missileRange = new StatCombination(StatCategory.ATTACK, StatEnum.MISSILE_RANGE, "Missile Range");
            StatsListing.Add(missileRange);

            StatCombination ramDamage = new StatCombination(StatCategory.ATTACK, StatEnum.RAM_DAMAGE, "Ram Damage");
            StatsListing.Add(ramDamage);

            StatCombination repairEfficiency = new StatCombination(StatCategory.UTILITY, StatEnum.REPAIR_EFFICIENCY, "Repair Efficiency");
            StatsListing.Add(repairEfficiency);

            StatCombination sensorRange = new StatCombination(StatCategory.UTILITY, StatEnum.SENSOR_RANGE, "Sensor Range");
            StatsListing.Add(sensorRange);

            StatCombination squadCooldown = new StatCombination(StatCategory.UTILITY, StatEnum.SQUAD_COOLDOWN, "Squad Cooldown");
            StatsListing.Add(squadCooldown);

            StatCombination StationDamageReduction = new StatCombination(StatCategory.DEFENSE, StatEnum.STATION_DAMAGE_REDUCTION, "Station Damage Reduction");
            StatsListing.Add(StationDamageReduction);

            StatCombination squadSurvival = new StatCombination(StatCategory.UTILITY, StatEnum.SQUAD_SURVIVAL, "Squad Survival");
            StatsListing.Add(squadSurvival);

            StatCombination turnRate = new StatCombination(StatCategory.UTILITY, StatEnum.TURN_RATE, "Turn Rate");
            StatsListing.Add(turnRate);

            StatCombination turretTraverse = new StatCombination(StatCategory.ATTACK, StatEnum.TURRET_TRAVERSE, "Turret Traverse");
            StatsListing.Add(turretTraverse);

            StatCombination utilityCooldown = new StatCombination(StatCategory.UTILITY, StatEnum.UTILITY_COOLDOWN, "Utility Cooldown");
            StatsListing.Add(utilityCooldown);

            StatCombination utilityDuration = new StatCombination(StatCategory.UTILITY, StatEnum.UTILITY_DURATION, "Utility Duration");
            StatsListing.Add(utilityDuration);

            // Energy effiency is last, as this list is shared between crew and implants. However implants doesn't have an equivalent
            StatCombination energyEfficiency = new StatCombination(StatCategory.UTILITY, StatEnum.ENERGY_EFFICIENCY, "Energy Efficiency");
            StatsListing.Add(energyEfficiency);
        }
    }
}
