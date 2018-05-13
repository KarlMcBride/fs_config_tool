using FS_Config_Tool;
using FS_Config_Tool.Classes;

namespace UnitTests.TestData
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

            config.CrewMembers[0].CrewID = CrewEnum.TEMPLE_JEMISON;
            config.CrewMembers[1].CrewID = CrewEnum.GOSS_REZNIK;
            config.CrewMembers[2].CrewID = CrewEnum.CLARA_REISETTE;
            config.CrewMembers[3].CrewID = CrewEnum.GREGORII_DUROV;
            config.CrewMembers[4].CrewID = CrewEnum.LUDOLOGIST;

            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                config.CrewMembers[crewIndex].ImplantIDs[0] = ImplantEnum.HULL_STRENGTH;
                config.CrewMembers[crewIndex].ImplantIDs[1] = ImplantEnum.MANEUVERING;
                config.CrewMembers[crewIndex].ImplantIDs[2] = ImplantEnum.UTILITY_COOLDOWN;
            }

            return config;
        }
    }
}
