using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;

namespace UnitTests.ConfigParsing.TestData
{
    public class ParsedData
    {
        public static TeamConfig ClaraOnlyNoImplants()
        {
            TeamConfig config = new TeamConfig();

            config.CrewMembers[2].CrewID = CrewEnum.CLARA_REISETTE;

            return config;
        }

        /// <summary>
        /// Test config with 3 crew and no captain - no implants
        /// </summary>
        /// <returns>Full team config for testing</returns>
        public static TeamConfig ThreeMembersNoCaptainNoImplants()
        {
            TeamConfig config = new TeamConfig();

            config.CrewMembers[0].CrewID = CrewEnum.RIDLEY_J_FINCHER;
            config.CrewMembers[3].CrewID = CrewEnum.MIA_JANSEN;
            config.CrewMembers[4].CrewID = CrewEnum.KRYSTEN_TCHAIKOVSKY;

            return config;
        }

        /// <summary>
        /// Test config with basic crew config - no implants
        /// </summary>
        /// <returns>Full team config for testing</returns>
        public static TeamConfig BasicFiveMembersNoImplants()
        {
            TeamConfig config = new TeamConfig();

            config.CrewMembers[0].CrewID = CrewEnum.ERNEST_GRIMUR;
            config.CrewMembers[1].CrewID = CrewEnum.MIRA_SHARMA;
            config.CrewMembers[2].CrewID = CrewEnum.MATSOKAH;
            config.CrewMembers[3].CrewID = CrewEnum.PROTAGONIST;
            config.CrewMembers[4].CrewID = CrewEnum.BONNY_REED;

            return config;
        }

        /// <summary>
        /// Test config with identical implant order for each crew member
        /// </summary>
        /// <returns>Full team config for testing</returns>
        public static TeamConfig FiveMembersFullImplantsOrdered()
        {
            TeamConfig config = new TeamConfig();

            config.CrewMembers[0].CrewID = CrewEnum.GRINCZ_MORROW;
            config.CrewMembers[1].CrewID = CrewEnum.HALO;
            config.CrewMembers[2].CrewID = CrewEnum.WHIM;
            config.CrewMembers[3].CrewID = CrewEnum.SARA_KRACE;
            config.CrewMembers[4].CrewID = CrewEnum.DICE_CAPLAN;

            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                config.CrewMembers[crewIndex].ImplantIDs[0] = ImplantEnum.DAMAGE_REDUCTION;
                config.CrewMembers[crewIndex].ImplantIDs[1] = ImplantEnum.TURRET_TRAVERSE;
                config.CrewMembers[crewIndex].ImplantIDs[2] = ImplantEnum.UTILITY_DURATION;
            }

            return config;
        }

        /// <summary>
        /// Test config with different implant order for each crew member
        /// </summary>
        /// <returns>Full team config for testing</returns>
        public static TeamConfig FiveMembersFullImplantsScattered()
        {
            TeamConfig config = new TeamConfig();

            config.CrewMembers[0].CrewID = CrewEnum.GRINCZ_MORROW;
            config.CrewMembers[0].ImplantIDs[0] = ImplantEnum.TURRET_TRAVERSE;
            config.CrewMembers[0].ImplantIDs[1] = ImplantEnum.DAMAGE_REDUCTION;
            config.CrewMembers[0].ImplantIDs[2] = ImplantEnum.UTILITY_COOLDOWN;

            config.CrewMembers[1].CrewID = CrewEnum.HALO;
            config.CrewMembers[1].ImplantIDs[0] = ImplantEnum.DAMAGE_REDUCTION;
            config.CrewMembers[1].ImplantIDs[1] = ImplantEnum.TURRET_TRAVERSE;
            config.CrewMembers[1].ImplantIDs[2] = ImplantEnum.UTILITY_COOLDOWN;

            config.CrewMembers[2].CrewID = CrewEnum.WHIM;
            config.CrewMembers[2].ImplantIDs[0] = ImplantEnum.TURRET_TRAVERSE;
            config.CrewMembers[2].ImplantIDs[1] = ImplantEnum.UTILITY_COOLDOWN;
            config.CrewMembers[2].ImplantIDs[2] = ImplantEnum.DAMAGE_REDUCTION;

            config.CrewMembers[3].CrewID = CrewEnum.SARA_KRACE;
            config.CrewMembers[3].ImplantIDs[0] = ImplantEnum.TURRET_TRAVERSE;
            config.CrewMembers[3].ImplantIDs[1] = ImplantEnum.DAMAGE_REDUCTION;
            config.CrewMembers[3].ImplantIDs[2] = ImplantEnum.UTILITY_COOLDOWN;

            config.CrewMembers[4].CrewID = CrewEnum.DICE_CAPLAN;
            config.CrewMembers[4].ImplantIDs[0] = ImplantEnum.UTILITY_COOLDOWN;
            config.CrewMembers[4].ImplantIDs[1] = ImplantEnum.DAMAGE_REDUCTION;
            config.CrewMembers[4].ImplantIDs[2] = ImplantEnum.TURRET_TRAVERSE;

            return config;
        }
    }
}
