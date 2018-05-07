using FS_Crew_Config_Tool.Classes.Listings;
using System.Collections.Generic;

namespace FS_Crew_Config_Tool
{
    public enum CrewRole
    {
        CAG,
        CAPTAIN,
        COMMS,
        ENGINEER,
        JUMP_CORE,
        NAV_OFFICER,
        REPAIR,
        TACTICAL,
        UTILITY,
        /// <summary>
        /// End of list value - for iteration
        /// </summary>
        NONE
    }

    public enum CrewEnum
    {
        // CAG
        ARKANY_KENA,
        CALANDRA_VANDENBERG,
        CPL_JOHNER_ONE,
        ERNEST_GRIMUR,
        MATILDA_ISAACS,
        SARA_KRACE,
        TEMPLE_JEMISON,
        // CAPTAIN
        CAESAR_MORGAN,
        CLARA_REISETTE,
        EVAN_STERLING,
        FRANK_TORRANCE,
        HANAKO_OGRADY,
        JONESY,
        MARIE_ANNE,
        MATSOKAH,
        THE_MIGHTY_JINGLES,
        WHIM,
        // COMMS
        BENJAMIN_PATRICK,
        LEXIN_KETHER,
        NESSA_MULLIGAN,
        PROTAGONIST,
        SAMUEL_MOSLEY,
        SURINDER_KAUR,
        XU_ZIYI,
        // ENGINEER
        BLADE,
        ELVY_COOPER,
        EMMINA_XINYU,
        GOSS_REZNIK,
        IMMIX_R,
        M1LCH0,
        MIA_JANSEN,
        RAGNAR_ZOREF,
        SILKE_KANESHIRO,
        // JUMP CORE
        ALA8AMA,
        CARZELLE_ODIARRE,
        HALO,
        HERA_DYMARR,
        ISABELLA_JAQ,
        KN1FE,
        MAX_DEMIAN,
        TELISIC_JENOVA,
        // NAV OFFICER
        BLAIN_ALLEN,
        BONNY_REED,
        CHARION_LLOYD,
        GREGORII_DUROV,
        IX_209,
        RU_T0LF,
        SEBASTIAN_BAROX,
        ZOE_LEDOUX,
        // REPAIR
        EVER_SWORD_KERN,
        LANCE_GREGORY,
        MAS_LEYDRAB,
        MIRA_SHARMA,
        RAYVAK_MOLK,
        REVOK_THORN,
        RIDLEY_J_FINCHER,
        STELLAN_SHAW,
        TYRAIN_DEMAM,
        // TACTICAL
        CORNELIUS_BAPTISTE,
        DICE_CAPLAN,
        ELAX_ZENCHAS,
        IMASA_OKADAS,
        JULES_VALENTINE,
        KRYSTEN_TCHAIKOVSKY,
        MAGGIE_471,
        TAU_IS,
        XERID_GREYFIST,
        // UTILITY
        GRINCZ_MORROW,
        LUDOLOGIST,
        PALAM0N,
        REGAN,
        SCALPEL,
        SERAPHINE_VEGA,
        ZHANG_TAO,
        /// <summary>
        /// End of list value - for iteration
        /// </summary>
        NONE
    }

    public struct CrewMember
    {
        public CrewEnum CharacterID { get; private set; }
        /// <summary>
        /// Name shown to user
        /// </summary>
        public string CharacterName { get; private set; }
        /// <summary>
        /// Crew role i.e. Captain, Tactical etc
        /// </summary>
        public CrewRole Role        { get; private set; }
        /// <summary>
        /// Hex string used to identify crew members in the config
        /// </summary>
        public string Code          { get; private set; }
        /// <summary>
        /// Stats for output through UI
        /// </summary>
        public StatCombination[] CrewStats;

        public CrewMember(CrewEnum id, string name, CrewRole role, string code)
        {
            CharacterID = id;
            CharacterName = name;
            Role = role;
            Code = code;

            int roleBonuses = (role == CrewRole.CAPTAIN) ? 3 : 2;
            CrewStats = new StatCombination[roleBonuses];

            switch (role)
            {
                case CrewRole.CAG:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.SQUAD_COOLDOWN];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.SQUAD_SURVIVAL];
                    break;
                }
                case CrewRole.CAPTAIN:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.ATTACK_DAMAGE];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.CAPTURE_RATE];
                    CrewStats[2] = StatList.StatsListing[(int)StatType.DAMAGE_REDUCTION];
                    break;
                }
                case CrewRole.COMMS:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.ENERGY_REGEN];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.SENSOR_RANGE];
                    break;
                }
                case CrewRole.ENGINEER:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.ARMOUR_STRENGTH];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.FORWARD_THRUST];
                    break;
                }
                case CrewRole.JUMP_CORE:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.JUMP_COOLDOWN];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.JUMP_PREP];
                    break;
                }
                case CrewRole.NAV_OFFICER:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.MANEUVERING];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.TURN_RATE];
                    break;
                }
                case CrewRole.REPAIR:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.BROKEN_ARMOUR_DAMAGE];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.ARMOUR_REPAIR_RATE];
                    break;
                }
                case CrewRole.TACTICAL:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.FIRE_RATE];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.TURRET_TRAVERSE];
                    break;
                    }
                case CrewRole.UTILITY:
                {
                    CrewStats[0] = StatList.StatsListing[(int)StatType.ENERGY_EFFICIENCY];
                    CrewStats[1] = StatList.StatsListing[(int)StatType.UTILITY_COOLDOWN];
                    break;
                }
            }
        }
    }

    public static class CrewList
    {
        public static List<CrewMember> CrewListing;

        public static void PopulateCrewList()
        {
            CrewListing = new List<CrewMember>();

            // ##### CAG #####
            
            CrewMember arkanyKena = new CrewMember(CrewEnum.ARKANY_KENA, "Arkany Kena", CrewRole.CAG, "FFBB0CD044585FA20397788DA4C8361B");
            arkanyKena.CrewStats[0].Value = -11.25f; // CD
            arkanyKena.CrewStats[1].Value = 11.25f;  // Survival
            CrewListing.Add(arkanyKena);

            CrewMember calandraVandenberg = new CrewMember(CrewEnum.CALANDRA_VANDENBERG , "Calandra Vandenberg", CrewRole.CAG, "E8C717004E2EE7154BF67B8F8E7F931D");
            calandraVandenberg.CrewStats[0].Value = -7.5f; // CD
            calandraVandenberg.CrewStats[1].Value = 15f;   // Survival
            CrewListing.Add(calandraVandenberg);

            CrewMember cplJohnerOne = new CrewMember(CrewEnum.CPL_JOHNER_ONE, "Cpl Johner One", CrewRole.CAG, "27E43DEC4D0DCD5C245E62B2A3A62CBC");
            cplJohnerOne.CrewStats[0].Value = -11.25f;  // CD
            cplJohnerOne.CrewStats[1].Value = 11.25f;   // Survival
            CrewListing.Add(cplJohnerOne);

            CrewMember ernestGrimur = new CrewMember(CrewEnum.ERNEST_GRIMUR, "Ernest Grimur", CrewRole.CAG, "F54C19614EED261DE7B5688440419793");
            cplJohnerOne.CrewStats[0].Value = -7.5f;    // CD
            cplJohnerOne.CrewStats[1].Value = 15f;      // Survival
            CrewListing.Add(ernestGrimur);

            CrewMember matildaIsaacs = new CrewMember(CrewEnum.MATILDA_ISAACS, "Matilda Isaacs", CrewRole.CAG, "5589B0694B749C382B0E9A95B2A500B5");
            matildaIsaacs.CrewStats[0].Value = -15f;    // CD
            matildaIsaacs.CrewStats[1].Value = 7.5f;    // Survival
            CrewListing.Add(matildaIsaacs);

            CrewMember saraKrace = new CrewMember(CrewEnum.SARA_KRACE, "Sara Krace", CrewRole.CAG, "EE367C3445C458B872DD99AA821954C7");
            saraKrace.CrewStats[0].Value = -7.5f;   // CD
            saraKrace.CrewStats[1].Value = 15f;     // Survival
            CrewListing.Add(saraKrace);

            CrewMember templeJemison = new CrewMember(CrewEnum.TEMPLE_JEMISON, "Temple Jemison", CrewRole.CAG, "C54041CE43F8A0E89B2E04ADA2ED147F");
            templeJemison.CrewStats[0].Value = -15f;    // CD
            templeJemison.CrewStats[1].Value = 7.5f;    // Survival
            CrewListing.Add(templeJemison);

            // ##### CAPTAIN #####
            
            CrewMember caesarMorgan = new CrewMember(CrewEnum.CAESAR_MORGAN, "Caesar Morgan", CrewRole.CAPTAIN, "9700066F4492A3B0FD601B9791D396D3");
            caesarMorgan.CrewStats[0].Value = 4f;       // Attack
            caesarMorgan.CrewStats[1].Value = 12.5f;    // Cap
            caesarMorgan.CrewStats[2].Value = 2.5f;     // Damage Reduction
            CrewListing.Add(caesarMorgan);

            CrewMember claraReisette = new CrewMember(CrewEnum.CLARA_REISETTE, "Clara Reisette", CrewRole.CAPTAIN, "469C924F46938892882C86B29AEC0787");
            claraReisette.CrewStats[0].Value = 1;       // Attack
            claraReisette.CrewStats[1].Value = 18.75f;  // Cap
            claraReisette.CrewStats[2].Value = 5f;      // Damage Reduction
            CrewListing.Add(claraReisette);

            CrewMember evanSterling = new CrewMember(CrewEnum.EVAN_STERLING, "Evan Sterling", CrewRole.CAPTAIN, "A3E3FD2D4F8A3A7B3C3ED392FDA7A83A");
            evanSterling.CrewStats[0].Value = 4f;       // Attack
            evanSterling.CrewStats[1].Value = 6.25f;    // Cap
            evanSterling.CrewStats[2].Value = 3.75f;    // Damage Reduction
            CrewListing.Add(evanSterling);

            CrewMember frankTorrance = new CrewMember(CrewEnum.FRANK_TORRANCE, "Frank Torrance", CrewRole.CAPTAIN, "114452A14736870E083AE9A565A66D32");
            frankTorrance.CrewStats[0].Value = 3f;      // Attack
            frankTorrance.CrewStats[1].Value = 6.25f;   // Cap
            frankTorrance.CrewStats[2].Value = 5f;      // Damage Reduction
            CrewListing.Add(frankTorrance);

            CrewMember hanakoOgrady = new CrewMember(CrewEnum.HANAKO_OGRADY, "Hanako O'Grady", CrewRole.CAPTAIN, "EAACCEB3473CF95EBF4945B659971EBD");
            hanakoOgrady.CrewStats[0].Value = 1f;       // Attack
            hanakoOgrady.CrewStats[1].Value = 18.75f;   // Cap
            hanakoOgrady.CrewStats[2].Value = 5f;       // Damage Reduction
            CrewListing.Add(hanakoOgrady);

            CrewMember jonesy = new CrewMember(CrewEnum.JONESY, "Jonesy", CrewRole.CAPTAIN, "8FAD1806478DF966360CF384F5C67AED");
            jonesy.CrewStats[0].Value = 4f;     // Attack
            jonesy.CrewStats[1].Value = 18.75f; // Cap
            jonesy.CrewStats[2].Value = 1.25f;  // Damage Reduction
            CrewListing.Add(jonesy);

            CrewMember marieAnne = new CrewMember(CrewEnum.MARIE_ANNE, "Marie-Anne Moreau", CrewRole.CAPTAIN, "BA551FBC4960C181F355B980AF657DCE");
            marieAnne.CrewStats[0].Value = 2f;      // Attack
            marieAnne.CrewStats[1].Value = 12.5f;   // Cap
            marieAnne.CrewStats[2].Value = 5f;      // Damage Reduction
            CrewListing.Add(marieAnne);

            CrewMember matsokah = new CrewMember(CrewEnum.MATSOKAH, "Matsokah", CrewRole.CAPTAIN, "042BA0E84DF3C80D6FD42B978AE41BFC");
            matsokah.CrewStats[0].Value = 3f;       // Attack
            matsokah.CrewStats[1].Value = 25f;      // Cap
            matsokah.CrewStats[2].Value = 1.25f;    // Damage Reduction
            CrewListing.Add(matsokah);

            CrewMember theMightyJingles = new CrewMember(CrewEnum.THE_MIGHTY_JINGLES, "The Mighty Jingles", CrewRole.CAPTAIN, "B5EA63044B50230C97A9F69E90841FFA");
            theMightyJingles.CrewStats[0].Value = 4f;       // Attack
            theMightyJingles.CrewStats[1].Value = 12.5f;    // Cap
            theMightyJingles.CrewStats[2].Value = 2.5f;     // Damage Reduction
            CrewListing.Add(theMightyJingles);

            CrewMember whim = new CrewMember(CrewEnum.WHIM, "WHIM", CrewRole.CAPTAIN, "6EEEB38D4CF8CCBA5265B490963A1B6B");
            whim.CrewStats[0].Value = 1f;       // Attack
            whim.CrewStats[1].Value = 25f;      // Cap
            whim.CrewStats[2].Value = 3.75f;    // Damage Reduction
            CrewListing.Add(whim);

            // ##### COMMS #####

            CrewMember benjaminPatrick = new CrewMember(CrewEnum.BENJAMIN_PATRICK, "Benjamin Patrick", CrewRole.COMMS, "0E661A1B4E8FC0DA2E21B0980FC8D48F");
            benjaminPatrick.CrewStats[0].Value = 7.5f;  // Energy Regen
            benjaminPatrick.CrewStats[1].Value = 8f;    // Sensor Range
            CrewListing.Add(benjaminPatrick);

            CrewMember lexinKether = new CrewMember(CrewEnum.LEXIN_KETHER, "Lexin Kether", CrewRole.COMMS, "4737EA7D4B691CFE1D3CB7A7ACA9D476");
            lexinKether.CrewStats[0].Value = 3.75f;  // Energy Regen
            lexinKether.CrewStats[1].Value = 16f;    // Sensor Range
            CrewListing.Add(lexinKether);

            CrewMember nessaMulligan = new CrewMember(CrewEnum.NESSA_MULLIGAN, "Nessa Mulligan", CrewRole.COMMS, "87CC780246FA51D090821E810163C124");
            nessaMulligan.CrewStats[0].Value = 5.63f;  // Energy Regen
            nessaMulligan.CrewStats[1].Value = 12f;    // Sensor Range
            CrewListing.Add(nessaMulligan);

            CrewMember protagonist = new CrewMember(CrewEnum.PROTAGONIST, "Protagonist", CrewRole.COMMS, "6869BC9F4EBD5180DE3B2A915131F0D6");
            protagonist.CrewStats[0].Value = 3.75f;  // Energy Regen
            protagonist.CrewStats[1].Value = 16f;    // Sensor Range
            CrewListing.Add(protagonist);

            CrewMember samuelMosley = new CrewMember(CrewEnum.SAMUEL_MOSLEY, "Samuel Mosley", CrewRole.COMMS, "0FEFF4C847450FCF4539E6A808210D20");
            samuelMosley.CrewStats[0].Value = 7.5f;  // Energy Regen
            samuelMosley.CrewStats[1].Value = 8f;    // Sensor Range
            CrewListing.Add(samuelMosley);

            CrewMember surinderKaur = new CrewMember(CrewEnum.SURINDER_KAUR, "Surinder Kaur", CrewRole.COMMS, "B3353CB04D89D2DE05B3239FDB0CDD64");
            surinderKaur.CrewStats[0].Value = 5.63f;  // Energy Regen
            surinderKaur.CrewStats[1].Value = 12f;    // Sensor Range
            CrewListing.Add(surinderKaur);

            CrewMember xuZiyi = new CrewMember(CrewEnum.XU_ZIYI, "Xu Ziyi", CrewRole.COMMS, "C06032324DA975929D6751BD9EDDCFFF");
            xuZiyi.CrewStats[0].Value = 5.63f;  // Energy Regen
            xuZiyi.CrewStats[1].Value = 12f;    // Sensor Range
            CrewListing.Add(xuZiyi);

            // ##### ENGINEER #####

            CrewMember blade = new CrewMember(CrewEnum.BLADE, "Blade", CrewRole.ENGINEER, "BCD8CC1F41A30706FE79808E99686F34");
            blade.CrewStats[0].Value = 9.38f;  // Armour Strength
            blade.CrewStats[1].Value = 5.63f;  // Forward Thrust
            CrewListing.Add(blade);

            CrewMember elvyCooper = new CrewMember(CrewEnum.ELVY_COOPER, "Elvy Cooper", CrewRole.ENGINEER, "00CF4ABB4849164394475884CDBD2FA2");
            elvyCooper.CrewStats[0].Value = 6.25f;  // Armour Strength
            elvyCooper.CrewStats[1].Value = 7.5f;   // Forward Thrust
            CrewListing.Add(elvyCooper);

            CrewMember emmimaXinyu = new CrewMember(CrewEnum.EMMINA_XINYU, "Emmima Xinyu", CrewRole.ENGINEER, "DE58A8B94BE28412B0AEC5851BF58E06");
            emmimaXinyu.CrewStats[0].Value = 6.25f; // Armour Strength
            emmimaXinyu.CrewStats[1].Value = 7.5f;  // Forward Thrust
            CrewListing.Add(emmimaXinyu);

            CrewMember gossReznik = new CrewMember(CrewEnum.GOSS_REZNIK, "Goss Reznik", CrewRole.ENGINEER, "34D3B51248D2D71DA09F49B70D527191");
            gossReznik.CrewStats[0].Value = 12.5f;  // Armour Strength
            gossReznik.CrewStats[1].Value = 3.75f;  // Forward Thrust
            CrewListing.Add(gossReznik);

            CrewMember immixR = new CrewMember(CrewEnum.IMMIX_R, "IMMIX-R", CrewRole.ENGINEER, "4FA7ED4E43526AD90D0A16ACBE74B7D0");
            immixR.CrewStats[0].Value = 12.5f;  // Armour Strength
            immixR.CrewStats[1].Value = 3.75f;  // Forward Thrust
            CrewListing.Add(immixR);

            CrewMember m1lch0 = new CrewMember(CrewEnum.M1LCH0, "M1LCH0", CrewRole.ENGINEER, "E8F9A6D044DD009264F232BAF5745B59");
            m1lch0.CrewStats[0].Value = 6.25f;  // Armour Strength
            m1lch0.CrewStats[1].Value = 7.5f;   // Forward Thrust
            CrewListing.Add(m1lch0);

            CrewMember miaJansen = new CrewMember(CrewEnum.MIA_JANSEN, "Mia Jansen", CrewRole.ENGINEER, "370F985448800E271DF35A905730FCFD");
            miaJansen.CrewStats[0].Value = 9.38f;   // Armour Strength
            miaJansen.CrewStats[1].Value = 5.63f;   // Forward Thrust
            CrewListing.Add(miaJansen);

            CrewMember ragnarZoref = new CrewMember(CrewEnum.RAGNAR_ZOREF, "Ragnar Zoref", CrewRole.ENGINEER, "C3587D4C4C1F4FB4667F81827D4D641C");
            ragnarZoref.CrewStats[0].Value = 12.5f; // Armour Strength
            ragnarZoref.CrewStats[1].Value = 3.75f; // Forward Thrust
            CrewListing.Add(ragnarZoref);

            CrewMember silkeKaneshiro = new CrewMember(CrewEnum.SILKE_KANESHIRO, "Silke Kaneshiro", CrewRole.ENGINEER, "270D6DE4487A83C2F8A42F817AFB4146");
            silkeKaneshiro.CrewStats[0].Value = 9.38f;  // Armour Strength
            silkeKaneshiro.CrewStats[1].Value = 5.63f;  // Forward Thrust
            CrewListing.Add(silkeKaneshiro);

            // ##### JUMP CORE #####

            CrewMember ala8ama = new CrewMember(CrewEnum.ALA8AMA, "ALA8AMA", CrewRole.JUMP_CORE, "DBA519884D2448B247F1BAB5B26F0FA0");
            ala8ama.CrewStats[0].Value = -10f;
            ala8ama.CrewStats[1].Value = -5f;
            CrewListing.Add(ala8ama);

            CrewMember carzelleOdiarre = new CrewMember(CrewEnum.CARZELLE_ODIARRE, "Carzelle Odiarre", CrewRole.JUMP_CORE, "69C4E15A416644CB171900865E5C8596");
            carzelleOdiarre.CrewStats[0].Value = -7.5f;
            carzelleOdiarre.CrewStats[1].Value = -7.5f;
            CrewListing.Add(carzelleOdiarre);

            CrewMember halo = new CrewMember(CrewEnum.HALO, "Halo", CrewRole.JUMP_CORE, "0CB4D1FC41D22624F2523DABA8461480");
            halo.CrewStats[0].Value = -5f;
            halo.CrewStats[1].Value = -10f;
            CrewListing.Add(halo);

            CrewMember heraDymarr = new CrewMember(CrewEnum.HERA_DYMARR, "Hera Dymarr", CrewRole.JUMP_CORE, "03596E2C403126695058DA968351CE1D");
            heraDymarr.CrewStats[0].Value = -10f;
            heraDymarr.CrewStats[1].Value = -5f;
            CrewListing.Add(heraDymarr);

            CrewMember isabellaJaq = new CrewMember(CrewEnum.ISABELLA_JAQ, "Isabella Jaq", CrewRole.JUMP_CORE, "753F38F3427D6BFDED1E33A31A506449");
            isabellaJaq.CrewStats[0].Value = -7.5f;
            isabellaJaq.CrewStats[1].Value = -7.5f;
            CrewListing.Add(isabellaJaq);

            CrewMember kn1fe = new CrewMember(CrewEnum.KN1FE, "KN1FE", CrewRole.JUMP_CORE, "C70284114856958E755BCD960D8DB4F7");
            kn1fe.CrewStats[0].Value = -7.5f;
            kn1fe.CrewStats[1].Value = -7.5f;
            CrewListing.Add(kn1fe);

            CrewMember maxDemian = new CrewMember(CrewEnum.MAX_DEMIAN, "Max Demian", CrewRole.JUMP_CORE, "7CD8F72B46FFD94EECFBA580AD4F622B");
            maxDemian.CrewStats[0].Value = -10f;
            maxDemian.CrewStats[1].Value = -5f;
            CrewListing.Add(maxDemian);

            CrewMember telisicJenova = new CrewMember(CrewEnum.TELISIC_JENOVA, "Telisic Jenova", CrewRole.JUMP_CORE, "D78315B84D2DF4764384E1A3710E0DB6");
            telisicJenova.CrewStats[0].Value = -5f;
            telisicJenova.CrewStats[1].Value = -10f;
            CrewListing.Add(telisicJenova);

            // ##### NAV OFFICER #####

            CrewMember blainAllen = new CrewMember(CrewEnum.BLAIN_ALLEN, "Blain Allen", CrewRole.NAV_OFFICER, "4F0EF7B14E249F490DA9D7999105919B");
            blainAllen.CrewStats[0].Value = 9f; // Maneuvering
            blainAllen.CrewStats[1].Value = 9f; // Turn Rate
            CrewListing.Add(blainAllen);

            CrewMember bonnyReed = new CrewMember(CrewEnum.BONNY_REED, "Bonny Reed", CrewRole.NAV_OFFICER, "24059A994492D0F581F4BBA34CF04F30");
            bonnyReed.CrewStats[0].Value = 6f;  // Maneuvering
            bonnyReed.CrewStats[1].Value = 12f; // Turn Rate
            CrewListing.Add(bonnyReed);

            CrewMember charionLloyd = new CrewMember(CrewEnum.CHARION_LLOYD, "Charion Lloyd", CrewRole.NAV_OFFICER, "8E2505D04ED1E3A502BC55BF20565FB1");
            charionLloyd.CrewStats[0].Value = 6f;   // Maneuvering
            charionLloyd.CrewStats[1].Value = 12f;  // Turn Rate
            CrewListing.Add(charionLloyd);

            CrewMember gregoriiDurov = new CrewMember(CrewEnum.GREGORII_DUROV, "Gregorii Durov", CrewRole.NAV_OFFICER, "3292E32F46F83E8EDB9B04BC49DC096C");
            gregoriiDurov.CrewStats[0].Value = 12f; // Maneuvering
            gregoriiDurov.CrewStats[1].Value = 6f;  // Turn Rate
            CrewListing.Add(gregoriiDurov);

            CrewMember ix209 = new CrewMember(CrewEnum.IX_209, "IX-209", CrewRole.NAV_OFFICER, "5881365442DBDBC583701C9C927AE487");
            ix209.CrewStats[0].Value = 9f;  // Maneuvering
            ix209.CrewStats[1].Value = 9f;  // Turn Rate
            CrewListing.Add(ix209);

            CrewMember rut0lf = new CrewMember(CrewEnum.RU_T0LF, "Ru-T0LF", CrewRole.NAV_OFFICER, "2023776347DBB48F15EF789DFDFEB9C6");
            rut0lf.CrewStats[0].Value = 12f;    // Maneuvering
            rut0lf.CrewStats[1].Value = 6f;     // Turn Rate
            CrewListing.Add(rut0lf);

            CrewMember sebastianBarox = new CrewMember(CrewEnum.SEBASTIAN_BAROX, "Sebastian Barox", CrewRole.NAV_OFFICER, "72D906A447E302DC3A3B9AB2A3E48DC4");
            sebastianBarox.CrewStats[0].Value = 6f;     // Maneuvering
            sebastianBarox.CrewStats[1].Value = 12f;    // Turn Rate
            CrewListing.Add(sebastianBarox);

            CrewMember zoeLedoux = new CrewMember(CrewEnum.ZOE_LEDOUX, "Zoe Ledoux", CrewRole.NAV_OFFICER, "C9E1CF554D3AA9ABBEACC29081923251");
            zoeLedoux.CrewStats[0].Value = 9f;  // Maneuvering
            zoeLedoux.CrewStats[1].Value = 9f;  // Turn Rate
            CrewListing.Add(zoeLedoux);

            // ##### REPAIR #####

            CrewMember everSwordKern = new CrewMember(CrewEnum.MAS_LEYDRAB, "Ever Sword Kern", CrewRole.REPAIR, "07FB941F4118D9C16F7194AF2DEE9236");
            everSwordKern.CrewStats[0].Value = 18.75f;  // BADR
            everSwordKern.CrewStats[1].Value = -9.37f;  // Armour Repair Rate
            CrewListing.Add(everSwordKern);

            CrewMember lanceGregory = new CrewMember(CrewEnum.LANCE_GREGORY, "Lance Gregory", CrewRole.REPAIR, "B25536CF42280EB3A851A19EFC566AF6");
            lanceGregory.CrewStats[0].Value = 12.5f;    // BADR
            lanceGregory.CrewStats[1].Value = -12.5f;   // Armour Repair Rate
            CrewListing.Add(lanceGregory);

            CrewMember masDreylab = new CrewMember(CrewEnum.MAS_LEYDRAB, "Mas Dreylab", CrewRole.REPAIR, "DCC3E4D34D881F9AD77A4485D49FADDB");
            masDreylab.CrewStats[0].Value = 12.5f;  // BADR
            masDreylab.CrewStats[1].Value = -12.5f; // Armour Repair Rate
            CrewListing.Add(masDreylab);

            CrewMember miraSharma = new CrewMember(CrewEnum.MIRA_SHARMA, "Mira Sharma", CrewRole.REPAIR, "97E4B6DE426E33CBD78D30888416E3B0");
            miraSharma.CrewStats[0].Value = 18.75f; // BADR
            miraSharma.CrewStats[1].Value = -9.37f; // Armour Repair Rate
            CrewListing.Add(miraSharma);

            CrewMember rayvakMolk = new CrewMember(CrewEnum.RAYVAK_MOLK, "Rayvak Molk", CrewRole.REPAIR, "01EFAA1A4FAD35C8F2AF29BB80D38505");
            rayvakMolk.CrewStats[0].Value = 25f;    // BADR
            rayvakMolk.CrewStats[1].Value = -6.25f; // Armour Repair Rate
            CrewListing.Add(rayvakMolk);

            CrewMember revokThorn = new CrewMember(CrewEnum.REVOK_THORN, "Revok Thorn", CrewRole.REPAIR, "1B5382DF460CA84BE24285A16393D7D1");
            revokThorn.CrewStats[0].Value = 12.5f;  // BADR
            revokThorn.CrewStats[1].Value = -12.5f; // Armour Repair Rate
            CrewListing.Add(revokThorn);

            CrewMember ridleyjFincher = new CrewMember(CrewEnum.RIDLEY_J_FINCHER, "Ridley J Fincher", CrewRole.REPAIR, "D84BFBD24EE5AADEA97A57ABDE5B8D06");
            ridleyjFincher.CrewStats[0].Value = 12.5f;  // BADR
            ridleyjFincher.CrewStats[1].Value = -12.5f; // Armour Repair Rate
            CrewListing.Add(ridleyjFincher);

            CrewMember stellanShaw = new CrewMember(CrewEnum.STELLAN_SHAW, "Stellan Shaw", CrewRole.REPAIR, "CC29E90E40459910158A85AA6AD80603");
            stellanShaw.CrewStats[0].Value = 25f;       // BADR
            stellanShaw.CrewStats[1].Value = -6.25f;    // Armour Repair Rate
            CrewListing.Add(stellanShaw);

            CrewMember tyrainDenam = new CrewMember(CrewEnum.TYRAIN_DEMAM, "Tyrain Demam", CrewRole.REPAIR, "739B3F2445F94A3F0AC41C8E420850BD");
            tyrainDenam.CrewStats[0].Value = 25f;       // BADR
            tyrainDenam.CrewStats[1].Value = -6.25f;    // Armour Repair Rate
            CrewListing.Add(tyrainDenam);

            // ##### TACTICAL #####

            CrewMember corneliusBaptiste = new CrewMember(CrewEnum.CORNELIUS_BAPTISTE, "Cornelius Baptiste", CrewRole.TACTICAL, "3B4C9D4447A2C279C70E8FB77C8D11C0");
            corneliusBaptiste.CrewStats[0].Value = 4f;      // Fire Rate
            corneliusBaptiste.CrewStats[1].Value = 12.5f;   // Turret Traverse
            CrewListing.Add(corneliusBaptiste);

            CrewMember diceCaplan = new CrewMember(CrewEnum.DICE_CAPLAN, "Dice Caplan", CrewRole.TACTICAL, "10D3DC5F47D80063D389A39B9E43C83A");
            diceCaplan.CrewStats[0].Value = 4f;     // Fire Rate
            diceCaplan.CrewStats[1].Value = 12.5f;  // Turret Traverse
            CrewListing.Add(diceCaplan);

            CrewMember elaxZenchas = new CrewMember(CrewEnum.ELAX_ZENCHAS, "Elax Zenchas", CrewRole.TACTICAL, "8EB81D644E79B44458C3CB897E42BA40");
            elaxZenchas.CrewStats[0].Value = 3f;        // Fire Rate
            elaxZenchas.CrewStats[1].Value = 18.75f;    // Turret Traverse
            CrewListing.Add(elaxZenchas);

            CrewMember imasaOkadas = new CrewMember(CrewEnum.IMASA_OKADAS, "Imasa Okadas", CrewRole.TACTICAL, "17EDB1EA49444C603573DFB410B2C262");
            imasaOkadas.CrewStats[0].Value = 2f;    // Fire Rate
            imasaOkadas.CrewStats[1].Value = 25f;   // Turret Traverse
            CrewListing.Add(imasaOkadas);

            CrewMember julesValentine = new CrewMember(CrewEnum.JULES_VALENTINE, "Jules Valentine", CrewRole.TACTICAL, "CC7A81AD4BB2E1BF90CEC1A3DAFAA373");
            julesValentine.CrewStats[0].Value = 2f;     // Fire Rate
            julesValentine.CrewStats[1].Value = 25f;    // Turret Traverse
            CrewListing.Add(julesValentine);

            CrewMember krystenTchaikovsky = new CrewMember(CrewEnum.KRYSTEN_TCHAIKOVSKY, "Krysten Tchaikovsky", CrewRole.TACTICAL, "50BECA4949A2848119822E82226063C1");
            krystenTchaikovsky.CrewStats[0].Value = 2f;     // Fire Rate
            krystenTchaikovsky.CrewStats[1].Value = 25f;    // Turret Traverse
            CrewListing.Add(krystenTchaikovsky);

            CrewMember maggie471 = new CrewMember(CrewEnum.MAGGIE_471, "471-Maggie", CrewRole.TACTICAL, "5E0939BE45877FBE5243A0AEDDC6697A");
            maggie471.CrewStats[0].Value = 3f;      // Fire Rate
            maggie471.CrewStats[1].Value = 18.75f;  // Turret Traverse
            CrewListing.Add(maggie471);

            CrewMember tauIs= new CrewMember(CrewEnum.TAU_IS, "TAU-IS", CrewRole.TACTICAL, "57B7C1F84E93CC90B5790383F7ABAD18");
            tauIs.CrewStats[0].Value = 4f;      // Fire Rate
            tauIs.CrewStats[1].Value = 12.5f;   // Turret Traverse
            CrewListing.Add(tauIs);

            CrewMember xeridGreyFist = new CrewMember(CrewEnum.XERID_GREYFIST, "Xerid Greyfist", CrewRole.TACTICAL, "73F6C37247301C1E28DC19BBD4A38DB2");
            xeridGreyFist.CrewStats[0].Value = 3f;      // Fire Rate
            xeridGreyFist.CrewStats[1].Value = 18.75f;  // Turret Traverse
            CrewListing.Add(xeridGreyFist);

            // ##### UTILITY #####

            CrewMember grinczMorrow = new CrewMember(CrewEnum.GRINCZ_MORROW, "Grincz Morrow", CrewRole.UTILITY, "ADB48C2049AD7E235ABB47818BBBA283");
            grinczMorrow.CrewStats[0].Value = 5.63f;    // Energy Eff
            grinczMorrow.CrewStats[1].Value = -5.62f;   // Utility Cooldown
            CrewListing.Add(grinczMorrow);

            CrewMember ludologist = new CrewMember(CrewEnum.LUDOLOGIST, "Ludologist", CrewRole.UTILITY, "5E0EC5464C707BD2491991B3031EC524");
            ludologist.CrewStats[0].Value = 3.75f;  // Energy Eff
            ludologist.CrewStats[1].Value = -7.5f;  // Utility Cooldown
            CrewListing.Add(ludologist);

            CrewMember palam0n = new CrewMember(CrewEnum.PALAM0N, "Palam0n", CrewRole.UTILITY, "555DCF064663C9470A03AD89978A710B");
            palam0n.CrewStats[0].Value = 3.75f; // Energy Eff
            palam0n.CrewStats[1].Value = -7.5f; // Utility Cooldown
            CrewListing.Add(palam0n);

            CrewMember regan = new CrewMember(CrewEnum.REGAN, "Regan", CrewRole.UTILITY, "C695059E4356F317E1A3F1B4A33107C2");
            regan.CrewStats[0].Value = 5.63f;   // Energy Eff
            regan.CrewStats[1].Value = -5.62f;  // Utility Cooldown
            CrewListing.Add(regan);

            CrewMember scalpel = new CrewMember(CrewEnum.SCALPEL, "5calpel", CrewRole.UTILITY, "0DEDBFCA443F59FF912CDC98A51AA3D3");
            scalpel.CrewStats[0].Value = 7.5f;      // Energy Eff
            scalpel.CrewStats[1].Value = -3.75f;    // Utility Cooldown
            CrewListing.Add(scalpel);

            CrewMember seraphineVega = new CrewMember(CrewEnum.SERAPHINE_VEGA, "Seraphine Vega", CrewRole.UTILITY, "FFEE8C2E420D6F18592FC7BD4A33070E");
            seraphineVega.CrewStats[0].Value = 5.63f;   // Energy Eff
            seraphineVega.CrewStats[1].Value = -5.62f;  // Utility Cooldown
            CrewListing.Add(seraphineVega);

            CrewMember zhangTao = new CrewMember(CrewEnum.ZHANG_TAO, "Zhang Tao", CrewRole.UTILITY, "0473AF5C437B066B20F23383B826D8CF");
            zhangTao.CrewStats[0].Value = 7.5f;     // Energy Eff
            zhangTao.CrewStats[1].Value = -3.75f;   // Utility Cooldown
            CrewListing.Add(zhangTao);
        }
    }
}
