using System.Collections.Generic;

namespace FS_Crew_Config_Tool.Classes
{
    public enum ImplantType
    {
        ATTACK,
        DEFENSE,
        UTILITY
    }

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
        SQUAD_SURVIVAL,
        STATION_DAMAGE_REDUCTION,
        TURN_RATE,
        TURRET_TRAVERSE,
        UTILITY_COOLDOWN,
        UTILITY_DURATION,
        // End of list
        NONE
    }

    public struct Implant
    {
        public ImplantEnum ID   { get; private set; }
        public string Name      { get; private set; }
        public ImplantType Role { get; private set; }
        public string Code      { get; private set; }
        public Stats ImplantStats;

        public Implant(ImplantEnum id, string name, ImplantType role, string code)
        {
            ID = id;
            Name = name;
            Role = role;
            Code = code;
            ImplantStats = new Stats();
        }
    }

    public static class ImplantList
    {
        public static List<Implant> ImplantListing;

        public static void PopulateImplantList()
        {
            ImplantListing = new List<Implant>();

            Implant armourRepairRate = new Implant(ImplantEnum.ARMOUR_REPAIR_RATE, "Armour Repair Rate", ImplantType.DEFENSE, "BB220E9345CEFD879D93838D549B26CF");
            armourRepairRate.ImplantStats.ArmourRepairRate = 5f;
            ImplantListing.Add(armourRepairRate);

            Implant armourStrength = new Implant(ImplantEnum.ARMOUR_STRENGTH, "Armour Strength", ImplantType.DEFENSE, "F9D3569E4C0C3D099650E78C4DC42CFD");
            armourStrength.ImplantStats.ArmourStrength = 2.5f;
            ImplantListing.Add(armourStrength);

            Implant attackDamage = new Implant(ImplantEnum.ATTACK_DAMAGE, "Attack Damage", ImplantType.ATTACK, "13DC022E42068C9E654115A05B41DE6E");
            attackDamage.ImplantStats.AttackDamage = 0.8f;
            ImplantListing.Add(attackDamage);

            Implant brokenArmourDamageReduction = new Implant(ImplantEnum.BROKEN_ARMOUR_DAMAGE, "Broken Armour Damage Reduction", ImplantType.DEFENSE, "5A718C99471772C79A8B90A146601748");
            brokenArmourDamageReduction.ImplantStats.BrokenArmourDamage = -2.5f;
            ImplantListing.Add(brokenArmourDamageReduction);

            Implant captureRate = new Implant(ImplantEnum.CAPTURE_RATE, "Capture Rate", ImplantType.UTILITY, "82D056B6474BBAD3362B58800F1AA504");
            captureRate.ImplantStats.Capturerate = 5f;
            ImplantListing.Add(captureRate);

            Implant damageReduction = new Implant(ImplantEnum.DAMAGE_REDUCTION, "Damage Reduction", ImplantType.DEFENSE, "6834E8D2431A8A8B1BF3BD84F0791B32");
            damageReduction.ImplantStats.DamageReduction = 1f;
            ImplantListing.Add(damageReduction);

            Implant energyRegen = new Implant(ImplantEnum.ENERGY_REGEN, "Energy Regen", ImplantType.UTILITY, "A170838E48D7C48E0DBB588BEDEF9C69");
            energyRegen.ImplantStats.EnergyRegen = 1.5f;
            ImplantListing.Add(energyRegen);

            Implant fireRate = new Implant(ImplantEnum.FIRE_RATE, "Fire Rate", ImplantType.ATTACK, "2EC7537F4193727447AC74B5A340345A");
            fireRate.ImplantStats.FireRate = 0.8f;
            ImplantListing.Add(fireRate);

            Implant forwardThrust = new Implant(ImplantEnum.FORWARD_THRUST, "Forward Thrust", ImplantType.UTILITY, "B5A88CCF4D16BC9605CB6ABC97289A45");
            forwardThrust.ImplantStats.ForwardThrust = 1.5f;
            ImplantListing.Add(forwardThrust);

            Implant hullStrength = new Implant(ImplantEnum.HULL_STRENGTH, "Hull Strength", ImplantType.DEFENSE, "B553F54842EF2379C90DF49836292A76");
            hullStrength.ImplantStats.HullStrength = 200;
            ImplantListing.Add(hullStrength);

            Implant jumpCooldown = new Implant(ImplantEnum.JUMP_COOLDOWN, "Jump Cooldown", ImplantType.DEFENSE, "571D88634AA9A06CF8703DB822AE72DA");
            jumpCooldown.ImplantStats.JumpCooldown = -2f;
            ImplantListing.Add(jumpCooldown);

            Implant jumpDamageReduction = new Implant(ImplantEnum.JUMP_DAMAGE_REDUCTION, "Jump Damage Reduction", ImplantType.DEFENSE, "89A55DFD46684A7E528D42BF1B141E2A");
            jumpDamageReduction.ImplantStats.JumpDamageReduction = 15f;
            ImplantListing.Add(jumpDamageReduction);

            Implant jumpPrep = new Implant(ImplantEnum.JUMP_PREP, "Jump Prep", ImplantType.UTILITY, "3DB3DB124F4C7504CEAD4F9AD02DA883");
            jumpPrep.ImplantStats.JumpPrep = -2f;
            ImplantListing.Add(jumpPrep);

            Implant maneuvering = new Implant(ImplantEnum.MANEUVERING, "Maneuvering", ImplantType.UTILITY, "E0DF7C9441151ED8AFD4ED9BF12DE8B6");
            maneuvering.ImplantStats.Maneuvering = 2.4f;
            ImplantListing.Add(maneuvering);

            Implant missileRange = new Implant(ImplantEnum.MISSILE_RANGE, "Missile Range", ImplantType.ATTACK, "FEE32FD44475D582E42A988A6338E6C5");
            missileRange.ImplantStats.MissileRange = 10f;
            ImplantListing.Add(missileRange);

            Implant rammingDamage = new Implant(ImplantEnum.RAMMING_DAMAGE, "Ramming Damage", ImplantType.ATTACK, "D3D9388C4A69F429C161E18C7978B5A4");
            rammingDamage.ImplantStats.RamDamage = 10f;
            ImplantListing.Add(rammingDamage);

            Implant repairEfficiency = new Implant(ImplantEnum.REPAIR_EFFICIENCY, "Repair Efficiency", ImplantType.UTILITY, "A7C4002144908C578C82EAACEED842B3");
            repairEfficiency.ImplantStats.RepairEfficiency = 4f;
            ImplantListing.Add(repairEfficiency);

            Implant sensorRange = new Implant(ImplantEnum.SENSOR_RANGE, "Sensor Range", ImplantType.UTILITY, "EC9B721447DF397CA0D7D0A1AEA12A0F");
            sensorRange.ImplantStats.SensorRange = 3.2f;
            ImplantListing.Add(sensorRange);

            Implant squadCooldown = new Implant(ImplantEnum.SQUAD_COOLDOWN, "Squad Cooldown", ImplantType.UTILITY, "FB3FE8FD4EAA331346C3E596B32CEEF4");
            squadCooldown.ImplantStats.SquadCooldown = -3f;
            ImplantListing.Add(squadCooldown);

            Implant squadSurvival = new Implant(ImplantEnum.SQUAD_SURVIVAL, "Squad Survival", ImplantType.UTILITY, "2357BFE34CED88AAD4FB458B644FD792");
            squadSurvival.ImplantStats.SquadSurvival = 3f;
            ImplantListing.Add(squadSurvival);

            Implant stationDamageReduction = new Implant(ImplantEnum.STATION_DAMAGE_REDUCTION, "Station Damage Reduction", ImplantType.DEFENSE, "3949CAB645FA818C56A12BB0063F0AAB");
            stationDamageReduction.ImplantStats.StationDamageReduction = 10f;
            ImplantListing.Add(stationDamageReduction);

            Implant turnRate = new Implant(ImplantEnum.TURN_RATE, "Turn Rate", ImplantType.UTILITY, "77B35B9844EAF5A526E422AFBCEA881D");
            turnRate.ImplantStats.TurnRate = 2.4f;
            ImplantListing.Add(turnRate);

            Implant turretTraverse = new Implant(ImplantEnum.TURRET_TRAVERSE, "Turret Traverse", ImplantType.ATTACK, "875C276B4215F18D0903C3852EBDC87C");
            turretTraverse.ImplantStats.TurretTraverse = 5f;
            ImplantListing.Add(turretTraverse);

            Implant utilityCooldown = new Implant(ImplantEnum.UTILITY_COOLDOWN, "Utility Cooldown", ImplantType.UTILITY, "EC1EE1F84F43B42461FD848FB3433529");
            utilityCooldown.ImplantStats.UtilityCooldown = -1.5f;
            ImplantListing.Add(utilityCooldown);

            Implant utilityDuration = new Implant(ImplantEnum.UTILITY_DURATION, "Utility Duration", ImplantType.UTILITY, "B91104CB422A09B829AB5D83ED7AF476");
            utilityDuration.ImplantStats.UtilityDuration = 4f;
            ImplantListing.Add(utilityDuration);
        }
    }
}
