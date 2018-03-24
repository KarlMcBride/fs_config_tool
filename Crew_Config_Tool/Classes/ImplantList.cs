using System.Collections.Generic;

namespace FS_Crew_Config_Tool.Classes
{
    enum ImplantType
    {
        ATTACK,
        DEFENSE,
        UTILITY
    }

    struct Implant
    {
        public string Name      { get; private set; }
        public ImplantType Role { get; private set; }
        public string Code      { get; private set; }
        public Stats ImplantStats;

        public Implant(string name, ImplantType role, string code)
        {
            Name = name;
            Role = role;
            Code = code;
            ImplantStats = new Stats();
        }
    }

    public class ImplantList
    {
        List<Implant> ImplantListing;

        public void PopulateImplantList()
        {
            ImplantListing = new List<Implant>();

            Implant armourRepairRate = new Implant("Armour Repair Rate", ImplantType.DEFENSE, "BB220E9345CEFD879D93838D549B26CF");
            armourRepairRate.ImplantStats.ArmourRepairRate = 5f;
            ImplantListing.Add(armourRepairRate);

            Implant armorStrength = new Implant("Armor Strength", ImplantType.DEFENSE, "F9D3569E4C0C3D099650E78C4DC42CFD");
            armorStrength.ImplantStats.ArmourStrength = 2.5f;
            ImplantListing.Add(armorStrength);

            Implant attackDamage = new Implant("Attack Damage", ImplantType.ATTACK, "13DC022E42068C9E654115A05B41DE6E");
            attackDamage.ImplantStats.AttackDamage = 0.8f;
            ImplantListing.Add(attackDamage);

            Implant brokenArmorDamageReduction = new Implant("Broken Armor Damage Reduction", ImplantType.DEFENSE, "5A718C99471772C79A8B90A146601748");
            brokenArmorDamageReduction.ImplantStats.BrokenArmourDamage = -2.5f;
            ImplantListing.Add(brokenArmorDamageReduction);

            Implant captureRate = new Implant("Capture Rate", ImplantType.UTILITY, "82D056B6474BBAD3362B58800F1AA504");
            captureRate.ImplantStats.Capturerate = 5f;
            ImplantListing.Add(captureRate);

            Implant damageReduction = new Implant("Damage Reduction", ImplantType.DEFENSE, "6834E8D2431A8A8B1BF3BD84F0791B32");
            damageReduction.ImplantStats.DamageReduction = 1f;
            ImplantListing.Add(damageReduction);

            Implant energyRegen = new Implant("Energy Regen", ImplantType.UTILITY, "A170838E48D7C48E0DBB588BEDEF9C69");
            energyRegen.ImplantStats.EnergyRegen = 1.5f;
            ImplantListing.Add(energyRegen);

            Implant fireRate = new Implant("Fire Rate", ImplantType.ATTACK, "2EC7537F4193727447AC74B5A340345A");
            fireRate.ImplantStats.FireRate = 0.8f;
            ImplantListing.Add(fireRate);

            Implant forwardThrust = new Implant("Forward Thrust", ImplantType.UTILITY, "B5A88CCF4D16BC9605CB6ABC97289A45");
            forwardThrust.ImplantStats.ForwardThrust = 1.5f;
            ImplantListing.Add(forwardThrust);

            Implant hullStrength = new Implant("Hull Strength", ImplantType.DEFENSE, "B553F54842EF2379C90DF49836292A76");
            hullStrength.ImplantStats.HullStrength = 200;
            ImplantListing.Add(hullStrength);

            Implant jumpCooldown = new Implant("Jump Cooldown", ImplantType.DEFENSE, "571D88634AA9A06CF8703DB822AE72DA");
            jumpCooldown.ImplantStats.JumpCooldown = -2f;
            ImplantListing.Add(jumpCooldown);

            Implant jumpDamageReduction = new Implant("Jump Damage Reduction", ImplantType.DEFENSE, "89A55DFD46684A7E528D42BF1B141E2A");
            jumpDamageReduction.ImplantStats.JumpDamageReduction = 15f;
            ImplantListing.Add(jumpDamageReduction);

            Implant jumpPrep = new Implant("Jump Prep", ImplantType.UTILITY, "3DB3DB124F4C7504CEAD4F9AD02DA883");
            jumpPrep.ImplantStats.JumpPrep = -2f;
            ImplantListing.Add(jumpPrep);

            Implant maneuvering = new Implant("Maneuvering", ImplantType.UTILITY, "E0DF7C9441151ED8AFD4ED9BF12DE8B6");
            maneuvering.ImplantStats.Maneuvering = 2.4f;
            ImplantListing.Add(maneuvering);

            Implant missileRange = new Implant("Missile Range", ImplantType.ATTACK, "FEE32FD44475D582E42A988A6338E6C5");
            missileRange.ImplantStats.MissileRange = 10f;
            ImplantListing.Add(missileRange);

            Implant rammingDamage = new Implant("Ramming Damage", ImplantType.ATTACK, "D3D9388C4A69F429C161E18C7978B5A4");
            rammingDamage.ImplantStats.RamDamage = 10f;
            ImplantListing.Add(rammingDamage);

            Implant repairEfficiency = new Implant("Repair Efficiency", ImplantType.UTILITY, "A7C4002144908C578C82EAACEED842B3");
            repairEfficiency.ImplantStats.RepairEfficiency = 4f;
            ImplantListing.Add(repairEfficiency);

            Implant sensorRange = new Implant("Sensor Range", ImplantType.UTILITY, "EC9B721447DF397CA0D7D0A1AEA12A0F");
            sensorRange.ImplantStats.SensorRange = 3.2f;
            ImplantListing.Add(sensorRange);

            Implant squadCooldown = new Implant("Squad Cooldown", ImplantType.UTILITY, "FB3FE8FD4EAA331346C3E596B32CEEF4");
            squadCooldown.ImplantStats.SquadCooldown = -3f;
            ImplantListing.Add(squadCooldown);

            Implant squadSurvival = new Implant("Squad Survival", ImplantType.UTILITY, "2357BFE34CED88AAD4FB458B644FD792");
            squadSurvival.ImplantStats.SquadSurvival = 3f;
            ImplantListing.Add(squadSurvival);

            Implant stationDamageReduction = new Implant("Station Damage Reduction", ImplantType.DEFENSE, "3949CAB645FA818C56A12BB0063F0AAB");
            stationDamageReduction.ImplantStats.StationDamageReduction = 10f;
            ImplantListing.Add(stationDamageReduction);

            Implant turnRate = new Implant("Turn Rate", ImplantType.UTILITY, "77B35B9844EAF5A526E422AFBCEA881D");
            turnRate.ImplantStats.TurnRate = 2.4f;
            ImplantListing.Add(turnRate);

            Implant turretTraverse = new Implant("Turret Traverse", ImplantType.ATTACK, "875C276B4215F18D0903C3852EBDC87C");
            turretTraverse.ImplantStats.TurretTraverse = 5f;
            ImplantListing.Add(turretTraverse);

            Implant utilityCooldown = new Implant("Utility Cooldown", ImplantType.UTILITY, "EC1EE1F84F43B42461FD848FB3433529");
            utilityCooldown.ImplantStats.UtilityCooldown = -1.5f;
            ImplantListing.Add(utilityCooldown);

            Implant utilityDuration = new Implant("Utility Duration", ImplantType.UTILITY, "B91104CB422A09B829AB5D83ED7AF476");
            utilityDuration.ImplantStats.UtilityDuration = 4f;
            ImplantListing.Add(utilityDuration);
        }
    }
}
