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
        UTILITY
    }

    public enum CrewEnum
    {
        // CAG
        ARKANY_KENA,
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
        SAMUEL_MOSELY,
        XU_ZIYI,
        // ENGINEER
        ELVY_COOPER,
        EMMIMINA_XIYU,
        GOSS_REZNIK,
        IMMIX_R,
        MIA_JENSEN,
        RAGNAR_ZOREF,
        SILKE_KANESHIRO,
        // JUMP CORE
        ALA8BAMA,
        CARZELLE_ODIARRE,
        HALO,
        HERA_DYMARR,
        ISABELLA_JAQ,
        MAX_DEMIAN,
        TELISIC_JENOVA,
        // NAV OFFICER
        BLAIN_ALLEN,
        BONNY_REID,
        CHARION_LLOYD,
        GREGORII_DUROV,
        IX209,
        RUT0LF,
        ZOE_LEDOUX,
        // REPAIR
        LANCE_GREGORY,
        MAS_DREYLAB,
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
        TAU_IS,
        XERID_GREYFIST,
        // UTILITY
        GRINCZ_MORROW,
        LUDOLOGIST,
        PALAM0N,
        REGAN,
        SERAPHINE_VEGA,
        ZHANG_TAO,
        // End of List
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
        public Stats CrewStats;

        public CrewMember(CrewEnum id, string name, CrewRole role, string code)
        {
            CharacterID = id;
            CharacterName = name;
            Role = role;
            Code = code;
            CrewStats = new Stats();
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
            arkanyKena.CrewStats.SquadCooldown = -11.25f;
            arkanyKena.CrewStats.SquadSurvival = 11.25f;
            CrewListing.Add(arkanyKena);

            CrewMember cplJohnerOne = new CrewMember(CrewEnum.CPL_JOHNER_ONE, "Cpl Johner One", CrewRole.CAG, "27E43DEC4D0DCD5C245E62B2A3A62CBC");
            cplJohnerOne.CrewStats.SquadCooldown = -11.25f;
            cplJohnerOne.CrewStats.SquadSurvival = 11.25f;
            CrewListing.Add(cplJohnerOne);

            CrewMember ernestGrimur = new CrewMember(CrewEnum.ERNEST_GRIMUR, "Ernest Grimur", CrewRole.CAG, "F54C19614EED261DE7B5688440419793");
            ernestGrimur.CrewStats.SquadCooldown = -7.5f;
            ernestGrimur.CrewStats.SquadSurvival = 15f;
            CrewListing.Add(ernestGrimur);

            CrewMember matildaIsaacs = new CrewMember(CrewEnum.MATILDA_ISAACS, "Matilda Isaacs", CrewRole.CAG, "5589B0694B749C382B0E9A95B2A500B5");
            matildaIsaacs.CrewStats.SquadCooldown = -15f;
            matildaIsaacs.CrewStats.SquadSurvival = 7.5f;
            CrewListing.Add(matildaIsaacs);

            CrewMember saraKrace = new CrewMember(CrewEnum.SARA_KRACE, "Sara Krace", CrewRole.CAG, "EE367C3445C458B872DD99AA821954C7");
            saraKrace.CrewStats.SquadCooldown = -7.5f;
            saraKrace.CrewStats.SquadSurvival = 15f;
            CrewListing.Add(saraKrace);

            CrewMember templeJemison = new CrewMember(CrewEnum.TEMPLE_JEMISON, "Temple Jemison", CrewRole.CAG, "C54041CE43F8A0E89B2E04ADA2ED147F");
            templeJemison.CrewStats.SquadCooldown = -15f;
            templeJemison.CrewStats.SquadSurvival = 7.5f;
            CrewListing.Add(templeJemison);

            // ##### CAPTAIN #####
            
            CrewMember caesarMorgan = new CrewMember(CrewEnum.CAESAR_MORGAN, "Caesar Morgan", CrewRole.CAPTAIN, "9700066F4492A3B0FD601B9791D396D3");
            caesarMorgan.CrewStats.AttackDamage = 4f;
            caesarMorgan.CrewStats.Capturerate = 12.5f;
            caesarMorgan.CrewStats.DamageReduction = 2.5f;
            CrewListing.Add(caesarMorgan);

            CrewMember claraReisette = new CrewMember(CrewEnum.CLARA_REISETTE, "Clara Reisette", CrewRole.CAPTAIN, "469C924F46938892882C86B29AEC0787");
            claraReisette.CrewStats.AttackDamage = 1;
            claraReisette.CrewStats.Capturerate = 18.75f;
            claraReisette.CrewStats.DamageReduction = 5f;
            CrewListing.Add(claraReisette);

            CrewMember evanSterling = new CrewMember(CrewEnum.EVAN_STERLING, "Evan Sterling", CrewRole.CAPTAIN, "A3E3FD2D4F8A3A7B3C3ED392FDA7A83A");
            evanSterling.CrewStats.AttackDamage = 4f;
            evanSterling.CrewStats.Capturerate = 6.25f;
            evanSterling.CrewStats.DamageReduction = 3.75f;
            CrewListing.Add(evanSterling);

            CrewMember frankTorrance = new CrewMember(CrewEnum.FRANK_TORRANCE, "Frank Torrance", CrewRole.CAPTAIN, "114452A14736870E083AE9A565A66D32");
            frankTorrance.CrewStats.AttackDamage = 3f;
            frankTorrance.CrewStats.Capturerate = 6.25f;
            frankTorrance.CrewStats.DamageReduction = 5f;
            CrewListing.Add(frankTorrance);

            CrewMember jonesy = new CrewMember(CrewEnum.JONESY, "Jonesy", CrewRole.CAPTAIN, "8FAD1806478DF966360CF384F5C67AED");
            jonesy.CrewStats.AttackDamage = 4f;
            jonesy.CrewStats.Capturerate = 18.75f;
            jonesy.CrewStats.DamageReduction = 1.25f;
            CrewListing.Add(jonesy);

            CrewMember marieAnne = new CrewMember(CrewEnum.MARIE_ANNE, "Marie-Anne Moreau", CrewRole.CAPTAIN, "BA551FBC4960C181F355B980AF657DCE");
            marieAnne.CrewStats.AttackDamage = 2f;
            marieAnne.CrewStats.Capturerate = 12.5f;
            marieAnne.CrewStats.DamageReduction = 5f;
            CrewListing.Add(marieAnne);

            CrewMember matsokah = new CrewMember(CrewEnum.MATSOKAH, "Matsokah", CrewRole.CAPTAIN, "042BA0E84DF3C80D6FD42B978AE41BFC");
            matsokah.CrewStats.AttackDamage = 3f;
            matsokah.CrewStats.Capturerate = 25f;
            matsokah.CrewStats.DamageReduction = 1.25f;
            CrewListing.Add(matsokah);

            CrewMember theMightyJingles = new CrewMember(CrewEnum.THE_MIGHTY_JINGLES, "The Mighty Jingles", CrewRole.CAPTAIN, "B5EA63044B50230C97A9F69E90841FFA");
            theMightyJingles.CrewStats.AttackDamage = 4f;
            theMightyJingles.CrewStats.Capturerate = 12.5f;
            theMightyJingles.CrewStats.DamageReduction = 2.5f;
            CrewListing.Add(theMightyJingles);

            CrewMember whim = new CrewMember(CrewEnum.WHIM, "WHIM", CrewRole.CAPTAIN, "6EEEB38D4CF8CCBA5265B490963A1B6B");
            whim.CrewStats.AttackDamage = 1f;
            whim.CrewStats.Capturerate = 25f;
            whim.CrewStats.DamageReduction = 3.75f;
            CrewListing.Add(whim);

            // ##### COMMS #####

            CrewMember benjaminPatrick = new CrewMember(CrewEnum.BENJAMIN_PATRICK, "Benjamin Patrick", CrewRole.COMMS, "0E661A1B4E8FC0DA2E21B0980FC8D48F");
            benjaminPatrick.CrewStats.EnergyRegen = 7.5f;
            benjaminPatrick.CrewStats.SensorRange = 8f;
            CrewListing.Add(benjaminPatrick);

            CrewMember lexinKether = new CrewMember(CrewEnum.LEXIN_KETHER, "Lexin Kether", CrewRole.COMMS, "4737EA7D4B691CFE1D3CB7A7ACA9D476");
            lexinKether.CrewStats.EnergyRegen = 3.75f;
            lexinKether.CrewStats.SensorRange = 16f;
            CrewListing.Add(lexinKether);

            CrewMember nessaMulligan = new CrewMember(CrewEnum.NESSA_MULLIGAN, "Nessa Mulligan", CrewRole.COMMS, "87CC780246FA51D090821E810163C124");
            nessaMulligan.CrewStats.EnergyRegen = 5.63f;
            nessaMulligan.CrewStats.SensorRange = 12f;
            CrewListing.Add(nessaMulligan);

            CrewMember protagonist = new CrewMember(CrewEnum.PROTAGONIST, "Protagonist", CrewRole.COMMS, "6869BC9F4EBD5180DE3B2A915131F0D6");
            protagonist.CrewStats.EnergyRegen = 3.75f;
            protagonist.CrewStats.SensorRange = 16f;
            CrewListing.Add(protagonist);

            CrewMember samuelMosley = new CrewMember(CrewEnum.SAMUEL_MOSELY, "Samuel Mosley", CrewRole.COMMS, "0FEFF4C847450FCF4539E6A808210D20");
            samuelMosley.CrewStats.EnergyRegen = 7.5f;
            samuelMosley.CrewStats.SensorRange = 8f;
            CrewListing.Add(samuelMosley);

            CrewMember xuZiyi = new CrewMember(CrewEnum.XU_ZIYI, "Xu Ziyi", CrewRole.COMMS, "C06032324DA975929D6751BD9EDDCFFF");
            xuZiyi.CrewStats.EnergyRegen = 5.63f;
            xuZiyi.CrewStats.SensorRange = 12f;
            CrewListing.Add(xuZiyi);

            // ##### ENGINEER #####

            CrewMember elvyCooper = new CrewMember(CrewEnum.ELVY_COOPER, "Elvy Cooper", CrewRole.ENGINEER, "00CF4ABB4849164394475884CDBD2FA2");
            elvyCooper.CrewStats.ArmourStrength = 6.25f;
            elvyCooper.CrewStats.ForwardThrust = 7.5f;
            CrewListing.Add(elvyCooper);

            CrewMember emmimaXinyu = new CrewMember(CrewEnum.EMMIMINA_XIYU, "Emmima Xinyu", CrewRole.ENGINEER, "DE58A8B94BE28412B0AEC5851BF58E06");
            emmimaXinyu.CrewStats.ArmourStrength = 6.25f;
            emmimaXinyu.CrewStats.ForwardThrust = 7.5f;
            CrewListing.Add(emmimaXinyu);

            CrewMember gossReznik = new CrewMember(CrewEnum.GOSS_REZNIK, "Goss Reznik", CrewRole.ENGINEER, "34D3B51248D2D71DA09F49B70D527191");
            gossReznik.CrewStats.ArmourStrength = 12.5f;
            gossReznik.CrewStats.ForwardThrust = 3.75f;
            CrewListing.Add(gossReznik);

            CrewMember immixR = new CrewMember(CrewEnum.IMMIX_R, "IMMIX-R", CrewRole.ENGINEER, "4FA7ED4E43526AD90D0A16ACBE74B7D0");
            immixR.CrewStats.ArmourStrength = 12.5f;
            immixR.CrewStats.ForwardThrust = 3.75f;
            CrewListing.Add(immixR);

            CrewMember miaJansen = new CrewMember(CrewEnum.MIA_JENSEN, "Mia Jansen", CrewRole.ENGINEER, "370F985448800E271DF35A905730FCFD");
            miaJansen.CrewStats.ArmourStrength = 9.38f;
            miaJansen.CrewStats.ForwardThrust = 5.63f;
            CrewListing.Add(miaJansen);

            CrewMember ragnarZoref = new CrewMember(CrewEnum.RAGNAR_ZOREF, "Ragnar Zoref", CrewRole.ENGINEER, "C3587D4C4C1F4FB4667F81827D4D641C");
            ragnarZoref.CrewStats.ArmourStrength = 12.5f;
            ragnarZoref.CrewStats.ForwardThrust = 3.75f;
            CrewListing.Add(ragnarZoref);

            CrewMember silkeKaneshiro = new CrewMember(CrewEnum.SILKE_KANESHIRO, "Silke Kaneshiro", CrewRole.ENGINEER, "270D6DE4487A83C2F8A42F817AFB4146");
            silkeKaneshiro.CrewStats.ArmourStrength = 9.38f;
            silkeKaneshiro.CrewStats.ForwardThrust = 5.63f;
            CrewListing.Add(silkeKaneshiro);

            // ##### JUMP CORE #####

            CrewMember ala8ama = new CrewMember(CrewEnum.ALA8BAMA, "ALA8AMA", CrewRole.JUMP_CORE, "DBA519884D2448B247F1BAB5B26F0FA0");
            ala8ama.CrewStats.JumpCooldown = -10f;
            ala8ama.CrewStats.JumpPrep = -5f;
            CrewListing.Add(ala8ama);

            CrewMember carzelleOdiarre = new CrewMember(CrewEnum.CARZELLE_ODIARRE, "Carzelle Odiarre", CrewRole.JUMP_CORE, "69C4E15A416644CB171900865E5C8596");
            carzelleOdiarre.CrewStats.JumpCooldown = -7.5f;
            carzelleOdiarre.CrewStats.JumpPrep = -7.5f;
            CrewListing.Add(carzelleOdiarre);

            CrewMember halo = new CrewMember(CrewEnum.HALO, "Halo", CrewRole.JUMP_CORE, "0CB4D1FC41D22624F2523DABA8461480");
            halo.CrewStats.JumpCooldown = -5f;
            halo.CrewStats.JumpPrep = -10f;
            CrewListing.Add(halo);

            CrewMember heraDymarr = new CrewMember(CrewEnum.HERA_DYMARR, "Hera Dymarr", CrewRole.JUMP_CORE, "03596E2C403126695058DA968351CE1D");
            heraDymarr.CrewStats.JumpCooldown = -10f;
            heraDymarr.CrewStats.JumpPrep = -5f;
            CrewListing.Add(heraDymarr);

            CrewMember isabellaJaq = new CrewMember(CrewEnum.ISABELLA_JAQ, "Isabella Jaq", CrewRole.JUMP_CORE, "753F38F3427D6BFDED1E33A31A506449");
            isabellaJaq.CrewStats.JumpCooldown = -7.5f;
            isabellaJaq.CrewStats.JumpPrep = -7.5f;
            CrewListing.Add(isabellaJaq);

            CrewMember maxDemian = new CrewMember(CrewEnum.MAX_DEMIAN, "Max Demian", CrewRole.JUMP_CORE, "7CD8F72B46FFD94EECFBA580AD4F622B");
            maxDemian.CrewStats.JumpCooldown = -10f;
            maxDemian.CrewStats.JumpPrep = -5f;
            CrewListing.Add(maxDemian);

            CrewMember telisicJenova = new CrewMember(CrewEnum.TELISIC_JENOVA, "Telisic Jenova", CrewRole.JUMP_CORE, "D78315B84D2DF4764384E1A3710E0DB6");
            telisicJenova.CrewStats.JumpCooldown = -5f;
            telisicJenova.CrewStats.JumpPrep = -10f;
            CrewListing.Add(telisicJenova);

            // ##### NAV OFFICER #####

            CrewMember blainAllen = new CrewMember(CrewEnum.BLAIN_ALLEN, "Blain Allen", CrewRole.NAV_OFFICER, "4F0EF7B14E249F490DA9D7999105919B");
            blainAllen.CrewStats.JumpCooldown = 9f;
            blainAllen.CrewStats.JumpPrep = 9f;
            CrewListing.Add(blainAllen);

            CrewMember bonnyReed = new CrewMember(CrewEnum.BONNY_REID, "Bonny Reed", CrewRole.NAV_OFFICER, "24059A994492D0F581F4BBA34CF04F30");
            bonnyReed.CrewStats.JumpCooldown = 6f;
            bonnyReed.CrewStats.JumpPrep = 12f;
            CrewListing.Add(bonnyReed);

            CrewMember charionLloyd = new CrewMember(CrewEnum.CHARION_LLOYD, "Charion Lloyd", CrewRole.NAV_OFFICER, "8E2505D04ED1E3A502BC55BF20565FB1");
            charionLloyd.CrewStats.JumpCooldown = 6f;
            charionLloyd.CrewStats.JumpPrep = 12f;
            CrewListing.Add(charionLloyd);

            CrewMember gregoriiDurov = new CrewMember(CrewEnum.GREGORII_DUROV, "Gregorii Durov", CrewRole.NAV_OFFICER, "3292E32F46F83E8EDB9B04BC49DC096C");
            gregoriiDurov.CrewStats.JumpCooldown = 12f;
            gregoriiDurov.CrewStats.JumpPrep = 6f;
            CrewListing.Add(gregoriiDurov);

            CrewMember ix209 = new CrewMember(CrewEnum.IX209, "IX-209", CrewRole.NAV_OFFICER, "5881365442DBDBC583701C9C927AE487");
            ix209.CrewStats.JumpCooldown = 9f;
            ix209.CrewStats.JumpPrep = 9f;
            CrewListing.Add(ix209);

            CrewMember rut0lf = new CrewMember(CrewEnum.RUT0LF, "Ru-T0LF", CrewRole.NAV_OFFICER, "2023776347DBB48F15EF789DFDFEB9C6");
            rut0lf.CrewStats.JumpCooldown = 12f;
            rut0lf.CrewStats.JumpPrep = 6f;
            CrewListing.Add(rut0lf);

            CrewMember zoeLedoux = new CrewMember(CrewEnum.ZOE_LEDOUX, "Zoe Ledoux", CrewRole.NAV_OFFICER, "C9E1CF554D3AA9ABBEACC29081923251");
            zoeLedoux.CrewStats.JumpCooldown = 9f;
            zoeLedoux.CrewStats.JumpPrep = 9f;
            CrewListing.Add(zoeLedoux);

            // ##### REPAIR #####

            CrewMember lanceGregory = new CrewMember(CrewEnum.LANCE_GREGORY, "Lance Gregory", CrewRole.REPAIR, "B25536CF42280EB3A851A19EFC566AF6");
            lanceGregory.CrewStats.ArmourRepairRate = 12.5f;
            lanceGregory.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(lanceGregory);

            CrewMember masDreylab = new CrewMember(CrewEnum.MAS_DREYLAB, "Mas Dreylab", CrewRole.REPAIR, "DCC3E4D34D881F9AD77A4485D49FADDB");
            masDreylab.CrewStats.ArmourRepairRate = 12.5f;
            masDreylab.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(masDreylab);

            CrewMember miraSharma = new CrewMember(CrewEnum.MIRA_SHARMA, "Mira Sharma", CrewRole.REPAIR, "97E4B6DE426E33CBD78D30888416E3B0");
            miraSharma.CrewStats.ArmourRepairRate = 18.75f;
            miraSharma.CrewStats.BrokenArmourDamage = -9.37f;
            CrewListing.Add(miraSharma);

            CrewMember rayvakMolk = new CrewMember(CrewEnum.RAYVAK_MOLK, "Rayvak Molk", CrewRole.REPAIR, "01EFAA1A4FAD35C8F2AF29BB80D38505");
            rayvakMolk.CrewStats.ArmourRepairRate = 25f;
            rayvakMolk.CrewStats.BrokenArmourDamage = -6.25f;
            CrewListing.Add(rayvakMolk);

            CrewMember revokThorn = new CrewMember(CrewEnum.REVOK_THORN, "Revok Thorn", CrewRole.REPAIR, "1B5382DF460CA84BE24285A16393D7D1");
            revokThorn.CrewStats.ArmourRepairRate = 12.5f;
            revokThorn.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(revokThorn);

            CrewMember ridleyjFincher = new CrewMember(CrewEnum.RIDLEY_J_FINCHER, "Ridley J Fincher", CrewRole.REPAIR, "D84BFBD24EE5AADEA97A57ABDE5B8D06");
            ridleyjFincher.CrewStats.ArmourRepairRate = 12.5f;
            ridleyjFincher.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(ridleyjFincher);

            CrewMember stellanShaw = new CrewMember(CrewEnum.STELLAN_SHAW, "Stellan Shaw", CrewRole.REPAIR, "CC29E90E40459910158A85AA6AD80603");
            stellanShaw.CrewStats.ArmourRepairRate = 25f;
            stellanShaw.CrewStats.BrokenArmourDamage = -6.25f;
            CrewListing.Add(stellanShaw);

            CrewMember tyrainDenam = new CrewMember(CrewEnum.TYRAIN_DEMAM, "Tyrain Demam", CrewRole.REPAIR, "739B3F2445F94A3F0AC41C8E420850BD");
            tyrainDenam.CrewStats.ArmourRepairRate = 25f;
            tyrainDenam.CrewStats.BrokenArmourDamage = -6.25f;
            CrewListing.Add(tyrainDenam);

            // ##### TACTICAL #####

            CrewMember corneliusBaptiste = new CrewMember(CrewEnum.CORNELIUS_BAPTISTE, "Cornelius Baptiste", CrewRole.TACTICAL, "3B4C9D4447A2C279C70E8FB77C8D11C0");
            corneliusBaptiste.CrewStats.FireRate = 4f;
            corneliusBaptiste.CrewStats.TurretTraverse = 12.5f;
            CrewListing.Add(corneliusBaptiste);

            CrewMember diceCaplan = new CrewMember(CrewEnum.DICE_CAPLAN, "Dice Caplan", CrewRole.TACTICAL, "10D3DC5F47D80063D389A39B9E43C83A");
            diceCaplan.CrewStats.FireRate = 4f;
            diceCaplan.CrewStats.TurretTraverse = 12.5f;
            CrewListing.Add(diceCaplan);

            CrewMember elaxZenchas = new CrewMember(CrewEnum.ELAX_ZENCHAS, "Elax Zenchas", CrewRole.TACTICAL, "8EB81D644E79B44458C3CB897E42BA40");
            elaxZenchas.CrewStats.FireRate = 3f;
            elaxZenchas.CrewStats.TurretTraverse = 18.75f;
            CrewListing.Add(elaxZenchas);

            CrewMember imasaOkadas = new CrewMember(CrewEnum.IMASA_OKADAS, "Imasa Okadas", CrewRole.TACTICAL, "17EDB1EA49444C603573DFB410B2C262");
            imasaOkadas.CrewStats.FireRate = 2f;
            imasaOkadas.CrewStats.TurretTraverse = 25f;
            CrewListing.Add(imasaOkadas);

            CrewMember julesValentine = new CrewMember(CrewEnum.JULES_VALENTINE, "Jules Valentine", CrewRole.TACTICAL, "CC7A81AD4BB2E1BF90CEC1A3DAFAA373");
            julesValentine.CrewStats.FireRate = 2f;
            julesValentine.CrewStats.TurretTraverse = 25f;
            CrewListing.Add(julesValentine);

            CrewMember krystenTchaikovsky = new CrewMember(CrewEnum.KRYSTEN_TCHAIKOVSKY, "Krysten Tchaikovsky", CrewRole.TACTICAL, "50BECA4949A2848119822E82226063C1");
            krystenTchaikovsky.CrewStats.FireRate = 2f;
            krystenTchaikovsky.CrewStats.TurretTraverse = 25f;
            CrewListing.Add(krystenTchaikovsky);

            CrewMember tauIs= new CrewMember(CrewEnum.TAU_IS, "TAU-IS", CrewRole.TACTICAL, "57B7C1F84E93CC90B5790383F7ABAD18");
            tauIs.CrewStats.FireRate = 4f;
            tauIs.CrewStats.TurretTraverse = 12.5f;
            CrewListing.Add(tauIs);

            CrewMember xeridGreyFist = new CrewMember(CrewEnum.XERID_GREYFIST, "Xerid Greyfist", CrewRole.TACTICAL, "57B7C1F84E93CC90B5790383F7ABAD18");
            xeridGreyFist.CrewStats.FireRate = 3f;
            xeridGreyFist.CrewStats.TurretTraverse = 18.75f;
            CrewListing.Add(xeridGreyFist);

            // ##### UTILITY #####

            CrewMember grinczMorrow = new CrewMember(CrewEnum.GRINCZ_MORROW, "Grincz Morrow", CrewRole.UTILITY, "ADB48C2049AD7E235ABB47818BBBA283");
            grinczMorrow.CrewStats.EnergyEfficiency = 5.63f;
            grinczMorrow.CrewStats.UtilityCooldown = -5.62f;
            CrewListing.Add(grinczMorrow);

            CrewMember ludologist = new CrewMember(CrewEnum.LUDOLOGIST, "Ludologist", CrewRole.UTILITY, "5E0EC5464C707BD2491991B3031EC524");
            ludologist.CrewStats.EnergyEfficiency = 3.75f;
            ludologist.CrewStats.UtilityCooldown = -7.5f;
            CrewListing.Add(ludologist);

            CrewMember palam0n = new CrewMember(CrewEnum.PALAM0N, "Palam0n", CrewRole.UTILITY, "555DCF064663C9470A03AD89978A710B");
            palam0n.CrewStats.EnergyEfficiency = 3.75f;
            palam0n.CrewStats.UtilityCooldown = -7.5f;
            CrewListing.Add(palam0n);

            CrewMember regan = new CrewMember(CrewEnum.REGAN, "Regan", CrewRole.UTILITY, "C695059E4356F317E1A3F1B4A33107C2");
            regan.CrewStats.EnergyEfficiency = 5.63f;
            regan.CrewStats.UtilityCooldown = -5.62f;
            CrewListing.Add(regan);

            CrewMember seraphineVega = new CrewMember(CrewEnum.SERAPHINE_VEGA, "Seraphine Vega", CrewRole.UTILITY, "FFEE8C2E420D6F18592FC7BD4A33070E");
            seraphineVega.CrewStats.EnergyEfficiency = 5.63f;
            seraphineVega.CrewStats.UtilityCooldown = -5.62f;
            CrewListing.Add(seraphineVega);

            CrewMember zhangTao = new CrewMember(CrewEnum.ZHANG_TAO, "Zhang Tao", CrewRole.UTILITY, "0473AF5C437B066B20F23383B826D8CF");
            zhangTao.CrewStats.EnergyEfficiency = 7.5f;
            zhangTao.CrewStats.UtilityCooldown = -3.75f;
            CrewListing.Add(zhangTao);
        }
    }
}
