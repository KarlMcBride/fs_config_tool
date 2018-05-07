using FS_Crew_Config_Tool.Classes.Listings;
using System.Collections.Generic;

namespace FS_Crew_Config_Tool.Classes
{
    public enum ImplantEnum
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
        RAMMING_DAMAGE,
        REPAIR_EFFICIENCY,
        SENSOR_RANGE,
        SQUAD_COOLDOWN,
        STATION_DAMAGE_REDUCTION,
        SQUAD_SURVIVAL,
        TURN_RATE,
        TURRET_TRAVERSE,
        UTILITY_COOLDOWN,
        UTILITY_DURATION,
        // End of list
        NONE
    }

    public struct Implant
    {
        public ImplantEnum ID        { get; private set; }
        public string Name           { get; private set; }
        public StatCategory Category { get; private set; }
        public StatType Type         { get; private set; }
        public string Code           { get; private set; }
        public StatCombination Stat  { get; private set; }

        public Implant(ImplantEnum id, string code, float stat)
        {
            ID = id;
            Name = StatList.StatsListing[(int)id].Name;
            Category = StatList.StatsListing[(int)id].Category;
            Type = StatList.StatsListing[(int)id].Type;
            Code = code;

            Stat = new StatCombination(Category, Type, Name, stat);
        }
    }

    public static class ImplantList
    {
        public static List<Implant> ImplantListing;

        public static void PopulateImplantList()
        {
            if (ImplantListing != null)
            {
                return;
            }

            ImplantListing = new List<Implant>();

            Implant armourRepairRate = new Implant(ImplantEnum.ARMOUR_REPAIR_RATE, "BB220E9345CEFD879D93838D549B26CF", 5f);
            ImplantListing.Add(armourRepairRate);

            Implant armourStrength = new Implant(ImplantEnum.ARMOUR_STRENGTH, "F9D3569E4C0C3D099650E78C4DC42CFD", 2.5f);
            ImplantListing.Add(armourStrength);

            Implant attackDamage = new Implant(ImplantEnum.ATTACK_DAMAGE, "13DC022E42068C9E654115A05B41DE6E", 0.8f);
            ImplantListing.Add(attackDamage);

            Implant brokenArmourDamageReduction = new Implant(ImplantEnum.BROKEN_ARMOUR_DAMAGE, "5A718C99471772C79A8B90A146601748", -2.5f);
            ImplantListing.Add(brokenArmourDamageReduction);

            Implant captureRate = new Implant(ImplantEnum.CAPTURE_RATE, "82D056B6474BBAD3362B58800F1AA504", 5f);
            ImplantListing.Add(captureRate);

            Implant damageReduction = new Implant(ImplantEnum.DAMAGE_REDUCTION, "6834E8D2431A8A8B1BF3BD84F0791B32", 1f);
            ImplantListing.Add(damageReduction);

            Implant energyRegen = new Implant(ImplantEnum.ENERGY_REGEN, "A170838E48D7C48E0DBB588BEDEF9C69", 1.5f);
            ImplantListing.Add(energyRegen);

            Implant fireRate = new Implant(ImplantEnum.FIRE_RATE, "2EC7537F4193727447AC74B5A340345A", 0.8f);
            ImplantListing.Add(fireRate);

            Implant forwardThrust = new Implant(ImplantEnum.FORWARD_THRUST, "B5A88CCF4D16BC9605CB6ABC97289A45", 1.5f);
            ImplantListing.Add(forwardThrust);

            Implant hullStrength = new Implant(ImplantEnum.HULL_STRENGTH, "B553F54842EF2379C90DF49836292A76", 200);
            ImplantListing.Add(hullStrength);

            Implant jumpCooldown = new Implant(ImplantEnum.JUMP_COOLDOWN, "571D88634AA9A06CF8703DB822AE72DA", -2f);
            ImplantListing.Add(jumpCooldown);

            Implant jumpDamageReduction = new Implant(ImplantEnum.JUMP_DAMAGE_REDUCTION, "89A55DFD46684A7E528D42BF1B141E2A", 15f);
            ImplantListing.Add(jumpDamageReduction);

            Implant jumpPrep = new Implant(ImplantEnum.JUMP_PREP, "3DB3DB124F4C7504CEAD4F9AD02DA883", -2f);
            ImplantListing.Add(jumpPrep);

            Implant maneuvering = new Implant(ImplantEnum.MANEUVERING, "E0DF7C9441151ED8AFD4ED9BF12DE8B6", 2.4f);
            ImplantListing.Add(maneuvering);

            Implant missileRange = new Implant(ImplantEnum.MISSILE_RANGE, "FEE32FD44475D582E42A988A6338E6C5", 10f);
            ImplantListing.Add(missileRange);

            Implant rammingDamage = new Implant(ImplantEnum.RAMMING_DAMAGE, "D3D9388C4A69F429C161E18C7978B5A4", 10f);
            ImplantListing.Add(rammingDamage);

            Implant repairEfficiency = new Implant(ImplantEnum.REPAIR_EFFICIENCY, "A7C4002144908C578C82EAACEED842B3", 4f);
            ImplantListing.Add(repairEfficiency);

            Implant sensorRange = new Implant(ImplantEnum.SENSOR_RANGE, "EC9B721447DF397CA0D7D0A1AEA12A0F", 3.2f);
            ImplantListing.Add(sensorRange);

            Implant squadCooldown = new Implant(ImplantEnum.SQUAD_COOLDOWN, "FB3FE8FD4EAA331346C3E596B32CEEF4", -3f);
            ImplantListing.Add(squadCooldown);

            Implant stationDamageReduction = new Implant(ImplantEnum.STATION_DAMAGE_REDUCTION, "3949CAB645FA818C56A12BB0063F0AAB", 10f);
            ImplantListing.Add(stationDamageReduction);

            Implant squadSurvival = new Implant(ImplantEnum.SQUAD_SURVIVAL, "2357BFE34CED88AAD4FB458B644FD792", 3f);
            ImplantListing.Add(squadSurvival);

            Implant turnRate = new Implant(ImplantEnum.TURN_RATE, "77B35B9844EAF5A526E422AFBCEA881D", 2.4f);
            ImplantListing.Add(turnRate);

            Implant turretTraverse = new Implant(ImplantEnum.TURRET_TRAVERSE, "875C276B4215F18D0903C3852EBDC87C", 5f);
            ImplantListing.Add(turretTraverse);

            Implant utilityCooldown = new Implant(ImplantEnum.UTILITY_COOLDOWN, "EC1EE1F84F43B42461FD848FB3433529", -1.5f);
            ImplantListing.Add(utilityCooldown);

            Implant utilityDuration = new Implant(ImplantEnum.UTILITY_DURATION, "B91104CB422A09B829AB5D83ED7AF476", 4f);
            ImplantListing.Add(utilityDuration);
        }
    }
}
