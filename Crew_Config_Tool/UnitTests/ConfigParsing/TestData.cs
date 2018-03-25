namespace UnitTests.ConfigParsing
{
    public static class TestData
    {
        public static string FIVE_MEMBERS_NO_IMPLANTS =
            "(ID=\"FFBB0CD044585FA20397788DA4C8361B\")," +
            "(ID=\"00CF4ABB4849164394475884CDBD2FA2\")," +
            "(ID=\"BA551FBC4960C181F355B980AF657DCE\")," +
            "(ID=\"C9E1CF554D3AA9ABBEACC29081923251\")," +
            "(ID=\"10D3DC5F47D80063D389A39B9E43C83A\")";

        public static string FIVE_MEMBERS_NO_IMPLANTS_FULL_STRING =
            "CrewTeams=(ID=\"C88443774D6346F59F4E1DA8F94529F2\",Name=\"Crew Only\",Icon=\"\"," +
            "CrewMembers=(" +
            "(ID=\"FFBB0CD044585FA20397788DA4C8361B\")," +
            "(ID=\"00CF4ABB4849164394475884CDBD2FA2\")," +
            "(ID=\"BA551FBC4960C181F355B980AF657DCE\")," +
            "(ID=\"C9E1CF554D3AA9ABBEACC29081923251\")," +
            "(ID=\"10D3DC5F47D80063D389A39B9E43C83A\")" +
            "),Members=)";
    }
}
