using FS_Config_Tool.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    public static class TeamConfigComparer
    {
        public static void VerifyCrewsMatch(TeamConfig expected, TeamConfig actual)
        {
            for (int crewIndex = 0; crewIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; crewIndex++)
            {
                Assert.AreEqual(expected.CrewMembers[crewIndex].CrewID, actual.CrewMembers[crewIndex].CrewID);

                for (int implantIndex = 0; implantIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; implantIndex++)
                {
                    Assert.AreEqual(expected.CrewMembers[crewIndex].ImplantIDs[implantIndex], actual.CrewMembers[crewIndex].ImplantIDs[implantIndex]);
                }
            }
        }
    }
}
