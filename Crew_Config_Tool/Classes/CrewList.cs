using System.Collections.Generic;

namespace FS_Crew_Config_Tool
{
    enum CrewRole
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

    struct CrewMember
    {
        public string CharacterName { get; private set; }
        public CrewRole Role        { get; private set; }
        public string Code          { get; private set; }
        public Stats CrewStats;

        public CrewMember(string name, CrewRole role, string code)
        {
            CharacterName = name;
            Role = role;
            Code = code;
            CrewStats = new Stats();
        }
    }

    public class CrewList
    {
        List<CrewMember> CrewListing;

        public void PopulateCrewList()
        {
            CrewListing = new List<CrewMember>();

            // ##### CAG #####
            
            CrewMember arkanyKena = new CrewMember("Arkany Kena", CrewRole.CAG, "FFBB0CD044585FA20397788DA4C8361B");
            arkanyKena.CrewStats.SquadCooldown = -11.25f;
            arkanyKena.CrewStats.SquadSurvival = 11.25f;
            CrewListing.Add(arkanyKena);

            CrewMember cplJohnerOne = new CrewMember("Cpl Johner One", CrewRole.CAG, "27E43DEC4D0DCD5C245E62B2A3A62CBC");
            cplJohnerOne.CrewStats.SquadCooldown = -11.25f;
            cplJohnerOne.CrewStats.SquadSurvival = 11.25f;
            CrewListing.Add(cplJohnerOne);

            CrewMember ernestGrimur = new CrewMember("Ernest Grimur", CrewRole.CAG, "F54C19614EED261DE7B5688440419793");
            ernestGrimur.CrewStats.SquadCooldown = -7.5f;
            ernestGrimur.CrewStats.SquadSurvival = 15f;
            CrewListing.Add(ernestGrimur);

            CrewMember matildaIsaacs = new CrewMember("Matilda Isaacs", CrewRole.CAG, "5589B0694B749C382B0E9A95B2A500B5");
            matildaIsaacs.CrewStats.SquadCooldown = -15f;
            matildaIsaacs.CrewStats.SquadSurvival = 7.5f;
            CrewListing.Add(matildaIsaacs);

            CrewMember saraKrace = new CrewMember("Sara Krace", CrewRole.CAG, "EE367C3445C458B872DD99AA821954C7");
            saraKrace.CrewStats.SquadCooldown = -7.5f;
            saraKrace.CrewStats.SquadSurvival = 15f;
            CrewListing.Add(saraKrace);

            CrewMember templeJemison = new CrewMember("Temple Jemison", CrewRole.CAG, "C54041CE43F8A0E89B2E04ADA2ED147F");
            templeJemison.CrewStats.SquadCooldown = -15f;
            templeJemison.CrewStats.SquadSurvival = 7.5f;
            CrewListing.Add(templeJemison);

            // ##### CAPTAIN #####
            
            CrewMember caesarMorgan = new CrewMember("Caesar Morgan", CrewRole.CAPTAIN, "9700066F4492A3B0FD601B9791D396D3");
            caesarMorgan.CrewStats.AttackDamage = 4f;
            caesarMorgan.CrewStats.Capturerate = 12.5f;
            caesarMorgan.CrewStats.DamageReduction = 2.5f;
            CrewListing.Add(caesarMorgan);

            CrewMember claraReisette = new CrewMember("Clara Reisette", CrewRole.CAPTAIN, "469C924F46938892882C86B29AEC0787");
            claraReisette.CrewStats.AttackDamage = 1;
            claraReisette.CrewStats.Capturerate = 18.75f;
            claraReisette.CrewStats.DamageReduction = 5f;
            CrewListing.Add(claraReisette);

            CrewMember evanSterling = new CrewMember("Evan Sterling", CrewRole.CAPTAIN, "A3E3FD2D4F8A3A7B3C3ED392FDA7A83A");
            evanSterling.CrewStats.AttackDamage = 4f;
            evanSterling.CrewStats.Capturerate = 6.25f;
            evanSterling.CrewStats.DamageReduction = 3.75f;
            CrewListing.Add(evanSterling);

            CrewMember frankTorrance = new CrewMember("Frank Torrance", CrewRole.CAPTAIN, "114452A14736870E083AE9A565A66D32");
            frankTorrance.CrewStats.AttackDamage = 3f;
            frankTorrance.CrewStats.Capturerate = 6.25f;
            frankTorrance.CrewStats.DamageReduction = 5f;
            CrewListing.Add(frankTorrance);

            CrewMember jonesy = new CrewMember("Jonesy", CrewRole.CAPTAIN, "8FAD1806478DF966360CF384F5C67AED");
            jonesy.CrewStats.AttackDamage = 4f;
            jonesy.CrewStats.Capturerate = 18.75f;
            jonesy.CrewStats.DamageReduction = 1.25f;
            CrewListing.Add(jonesy);

            CrewMember marieAnne = new CrewMember("Marie-Anne Moreau", CrewRole.CAPTAIN, "BA551FBC4960C181F355B980AF657DCE");
            marieAnne.CrewStats.AttackDamage = 2f;
            marieAnne.CrewStats.Capturerate = 12.5f;
            marieAnne.CrewStats.DamageReduction = 5f;
            CrewListing.Add(marieAnne);

            CrewMember matsokah = new CrewMember("Matsokah", CrewRole.CAPTAIN, "042BA0E84DF3C80D6FD42B978AE41BFC");
            matsokah.CrewStats.AttackDamage = 3f;
            matsokah.CrewStats.Capturerate = 25f;
            matsokah.CrewStats.DamageReduction = 1.25f;
            CrewListing.Add(matsokah);

            CrewMember theMightyJingles = new CrewMember("The Mighty Jingles", CrewRole.CAPTAIN, "B5EA63044B50230C97A9F69E90841FFA");
            theMightyJingles.CrewStats.AttackDamage = 4f;
            theMightyJingles.CrewStats.Capturerate = 12.5f;
            theMightyJingles.CrewStats.DamageReduction = 2.5f;
            CrewListing.Add(theMightyJingles);

            CrewMember whim = new CrewMember("WHIM", CrewRole.CAPTAIN, "6EEEB38D4CF8CCBA5265B490963A1B6B");
            whim.CrewStats.AttackDamage = 1f;
            whim.CrewStats.Capturerate = 25f;
            whim.CrewStats.DamageReduction = 3.75f;
            CrewListing.Add(whim);

            // ##### COMMS #####

            CrewMember benjaminPatrick = new CrewMember("Benjamin Patrick", CrewRole.COMMS, "0E661A1B4E8FC0DA2E21B0980FC8D48F");
            benjaminPatrick.CrewStats.EnergyRegen = 7.5f;
            benjaminPatrick.CrewStats.SensorRange = 8f;
            CrewListing.Add(benjaminPatrick);

            CrewMember lexinKether = new CrewMember("Lexin Kether", CrewRole.COMMS, "4737EA7D4B691CFE1D3CB7A7ACA9D476");
            lexinKether.CrewStats.EnergyRegen = 3.75f;
            lexinKether.CrewStats.SensorRange = 16f;
            CrewListing.Add(lexinKether);

            CrewMember nessaMulligan = new CrewMember("Nessa Mulligan", CrewRole.COMMS, "87CC780246FA51D090821E810163C124");
            nessaMulligan.CrewStats.EnergyRegen = 5.63f;
            nessaMulligan.CrewStats.SensorRange = 12f;
            CrewListing.Add(nessaMulligan);

            CrewMember protagonist = new CrewMember("Protagonist", CrewRole.COMMS, "6869BC9F4EBD5180DE3B2A915131F0D6");
            protagonist.CrewStats.EnergyRegen = 3.75f;
            protagonist.CrewStats.SensorRange = 16f;
            CrewListing.Add(protagonist);

            CrewMember samuelMosley = new CrewMember("Samuel Mosley", CrewRole.COMMS, "0FEFF4C847450FCF4539E6A808210D20");
            samuelMosley.CrewStats.EnergyRegen = 7.5f;
            samuelMosley.CrewStats.SensorRange = 8f;
            CrewListing.Add(samuelMosley);

            CrewMember xuZiyi = new CrewMember("Xu Ziyi", CrewRole.COMMS, "C06032324DA975929D6751BD9EDDCFFF");
            xuZiyi.CrewStats.EnergyRegen = 5.63f;
            xuZiyi.CrewStats.SensorRange = 12f;
            CrewListing.Add(xuZiyi);

            // ##### ENGINEER #####

            CrewMember elvyCooper = new CrewMember("Elvy Cooper", CrewRole.ENGINEER, "00CF4ABB4849164394475884CDBD2FA2");
            elvyCooper.CrewStats.ArmourStrength = 6.25f;
            elvyCooper.CrewStats.ForwardThrust = 7.5f;
            CrewListing.Add(elvyCooper);

            CrewMember emmimaXinyu = new CrewMember("Emmima Xinyu", CrewRole.ENGINEER, "DE58A8B94BE28412B0AEC5851BF58E06");
            emmimaXinyu.CrewStats.ArmourStrength = 6.25f;
            emmimaXinyu.CrewStats.ForwardThrust = 7.5f;
            CrewListing.Add(emmimaXinyu);

            CrewMember gossReznik = new CrewMember("Goss Reznik", CrewRole.ENGINEER, "34D3B51248D2D71DA09F49B70D527191");
            gossReznik.CrewStats.ArmourStrength = 12.5f;
            gossReznik.CrewStats.ForwardThrust = 3.75f;
            CrewListing.Add(gossReznik);

            CrewMember immixR = new CrewMember("IMMIX-R", CrewRole.ENGINEER, "4FA7ED4E43526AD90D0A16ACBE74B7D0");
            immixR.CrewStats.ArmourStrength = 12.5f;
            immixR.CrewStats.ForwardThrust = 3.75f;
            CrewListing.Add(immixR);

            CrewMember miaJansen = new CrewMember("Mia Jansen", CrewRole.ENGINEER, "370F985448800E271DF35A905730FCFD");
            miaJansen.CrewStats.ArmourStrength = 9.38f;
            miaJansen.CrewStats.ForwardThrust = 5.63f;
            CrewListing.Add(miaJansen);

            CrewMember ragnarZoref = new CrewMember("Ragnar Zoref", CrewRole.ENGINEER, "C3587D4C4C1F4FB4667F81827D4D641C");
            ragnarZoref.CrewStats.ArmourStrength = 12.5f;
            ragnarZoref.CrewStats.ForwardThrust = 3.75f;
            CrewListing.Add(ragnarZoref);

            CrewMember silkeKaneshiro = new CrewMember("Silke Kaneshiro", CrewRole.ENGINEER, "270D6DE4487A83C2F8A42F817AFB4146");
            silkeKaneshiro.CrewStats.ArmourStrength = 9.38f;
            silkeKaneshiro.CrewStats.ForwardThrust = 5.63f;
            CrewListing.Add(silkeKaneshiro);

            // ##### JUMP CORE #####

            CrewMember ala8ama = new CrewMember("ALA8AMA", CrewRole.JUMP_CORE, "DBA519884D2448B247F1BAB5B26F0FA0");
            ala8ama.CrewStats.JumpCooldown = -10f;
            ala8ama.CrewStats.JumpPrep = -5f;
            CrewListing.Add(ala8ama);

            CrewMember carzelleOdiarre = new CrewMember("Carzelle Odiarre", CrewRole.JUMP_CORE, "69C4E15A416644CB171900865E5C8596");
            carzelleOdiarre.CrewStats.JumpCooldown = -7.5f;
            carzelleOdiarre.CrewStats.JumpPrep = -7.5f;
            CrewListing.Add(carzelleOdiarre);

            CrewMember halo = new CrewMember("Halo", CrewRole.JUMP_CORE, "0CB4D1FC41D22624F2523DABA8461480");
            halo.CrewStats.JumpCooldown = -5f;
            halo.CrewStats.JumpPrep = -10f;
            CrewListing.Add(halo);

            CrewMember heraDymarr = new CrewMember("Hera Dymarr", CrewRole.JUMP_CORE, "03596E2C403126695058DA968351CE1D");
            heraDymarr.CrewStats.JumpCooldown = -10f;
            heraDymarr.CrewStats.JumpPrep = -5f;
            CrewListing.Add(heraDymarr);

            CrewMember isabellaJaq = new CrewMember("Isabella Jaq", CrewRole.JUMP_CORE, "753F38F3427D6BFDED1E33A31A506449");
            isabellaJaq.CrewStats.JumpCooldown = -7.5f;
            isabellaJaq.CrewStats.JumpPrep = -7.5f;
            CrewListing.Add(isabellaJaq);

            CrewMember maxDemian = new CrewMember("Max Demian", CrewRole.JUMP_CORE, "7CD8F72B46FFD94EECFBA580AD4F622B");
            maxDemian.CrewStats.JumpCooldown = -10f;
            maxDemian.CrewStats.JumpPrep = -5f;
            CrewListing.Add(maxDemian);

            CrewMember telisicJenova = new CrewMember("Telisic Jenova", CrewRole.JUMP_CORE, "D78315B84D2DF4764384E1A3710E0DB6");
            telisicJenova.CrewStats.JumpCooldown = -5f;
            telisicJenova.CrewStats.JumpPrep = -10f;
            CrewListing.Add(telisicJenova);

            // ##### NAV OFFICER #####

            CrewMember blainAllen = new CrewMember("Blain Allen", CrewRole.NAV_OFFICER, "4F0EF7B14E249F490DA9D7999105919B");
            blainAllen.CrewStats.JumpCooldown = 9f;
            blainAllen.CrewStats.JumpPrep = 9f;
            CrewListing.Add(blainAllen);

            CrewMember bonnyReed = new CrewMember("Bonny Reed", CrewRole.NAV_OFFICER, "24059A994492D0F581F4BBA34CF04F30");
            bonnyReed.CrewStats.JumpCooldown = 6f;
            bonnyReed.CrewStats.JumpPrep = 12f;
            CrewListing.Add(bonnyReed);

            CrewMember charionLloyd = new CrewMember("Charion Lloyd", CrewRole.NAV_OFFICER, "8E2505D04ED1E3A502BC55BF20565FB1");
            charionLloyd.CrewStats.JumpCooldown = 6f;
            charionLloyd.CrewStats.JumpPrep = 12f;
            CrewListing.Add(charionLloyd);

            CrewMember gregoriiDurov = new CrewMember("Gregorii Durov", CrewRole.NAV_OFFICER, "3292E32F46F83E8EDB9B04BC49DC096C");
            gregoriiDurov.CrewStats.JumpCooldown = 12f;
            gregoriiDurov.CrewStats.JumpPrep = 6f;
            CrewListing.Add(gregoriiDurov);

            CrewMember ix209 = new CrewMember("IX-209", CrewRole.NAV_OFFICER, "5881365442DBDBC583701C9C927AE487");
            ix209.CrewStats.JumpCooldown = 9f;
            ix209.CrewStats.JumpPrep = 9f;
            CrewListing.Add(ix209);

            CrewMember rut0lf = new CrewMember("Ru-T0LF", CrewRole.NAV_OFFICER, "2023776347DBB48F15EF789DFDFEB9C6");
            rut0lf.CrewStats.JumpCooldown = 12f;
            rut0lf.CrewStats.JumpPrep = 6f;
            CrewListing.Add(rut0lf);

            CrewMember zoeLedoux = new CrewMember("Zoe Ledoux", CrewRole.NAV_OFFICER, "C9E1CF554D3AA9ABBEACC29081923251");
            zoeLedoux.CrewStats.JumpCooldown = 9f;
            zoeLedoux.CrewStats.JumpPrep = 9f;
            CrewListing.Add(zoeLedoux);

            // ##### REPAIR #####

            CrewMember lanceGregory = new CrewMember("Lance Gregory", CrewRole.REPAIR, "B25536CF42280EB3A851A19EFC566AF6");
            lanceGregory.CrewStats.ArmourRepairRate = 12.5f;
            lanceGregory.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(lanceGregory);

            CrewMember masDreylab = new CrewMember("Mas Dreylab", CrewRole.REPAIR, "DCC3E4D34D881F9AD77A4485D49FADDB");
            masDreylab.CrewStats.ArmourRepairRate = 12.5f;
            masDreylab.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(masDreylab);

            CrewMember miraSharma = new CrewMember("Mira Sharma", CrewRole.REPAIR, "97E4B6DE426E33CBD78D30888416E3B0");
            miraSharma.CrewStats.ArmourRepairRate = 18.75f;
            miraSharma.CrewStats.BrokenArmourDamage = -9.37f;
            CrewListing.Add(miraSharma);

            CrewMember rayvakVolk = new CrewMember("Rayvak Volk", CrewRole.REPAIR, "01EFAA1A4FAD35C8F2AF29BB80D38505");
            rayvakVolk.CrewStats.ArmourRepairRate = 25f;
            rayvakVolk.CrewStats.BrokenArmourDamage = -6.25f;
            CrewListing.Add(rayvakVolk);

            CrewMember revokThorn = new CrewMember("Revok Thorn", CrewRole.REPAIR, "1B5382DF460CA84BE24285A16393D7D1");
            revokThorn.CrewStats.ArmourRepairRate = 12.5f;
            revokThorn.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(revokThorn);

            CrewMember ridleyjFincher = new CrewMember("Ridley J Fincher", CrewRole.REPAIR, "D84BFBD24EE5AADEA97A57ABDE5B8D06");
            ridleyjFincher.CrewStats.ArmourRepairRate = 12.5f;
            ridleyjFincher.CrewStats.BrokenArmourDamage = -12.5f;
            CrewListing.Add(ridleyjFincher);

            CrewMember stellanShaw = new CrewMember("Stellan Shaw", CrewRole.REPAIR, "CC29E90E40459910158A85AA6AD80603");
            stellanShaw.CrewStats.ArmourRepairRate = 25f;
            stellanShaw.CrewStats.BrokenArmourDamage = -6.25f;
            CrewListing.Add(stellanShaw);

            CrewMember tyrainDenam = new CrewMember("Tyrain Demam", CrewRole.REPAIR, "739B3F2445F94A3F0AC41C8E420850BD");
            tyrainDenam.CrewStats.ArmourRepairRate = 25f;
            tyrainDenam.CrewStats.BrokenArmourDamage = -6.25f;
            CrewListing.Add(tyrainDenam);

            // ##### TACTICAL #####

            CrewMember corneliusBaptiste = new CrewMember("Cornelius Baptiste", CrewRole.TACTICAL, "3B4C9D4447A2C279C70E8FB77C8D11C0");
            corneliusBaptiste.CrewStats.FireRate = 4f;
            corneliusBaptiste.CrewStats.TurretTraverse = 12.5f;
            CrewListing.Add(corneliusBaptiste);

            CrewMember diceCaplan = new CrewMember("Dice Caplan", CrewRole.TACTICAL, "10D3DC5F47D80063D389A39B9E43C83A");
            diceCaplan.CrewStats.FireRate = 4f;
            diceCaplan.CrewStats.TurretTraverse = 12.5f;
            CrewListing.Add(diceCaplan);

            CrewMember elaxZenchas = new CrewMember("Elax Zenchas", CrewRole.TACTICAL, "8EB81D644E79B44458C3CB897E42BA40");
            elaxZenchas.CrewStats.FireRate = 3f;
            elaxZenchas.CrewStats.TurretTraverse = 18.75f;
            CrewListing.Add(elaxZenchas);

            CrewMember imasaOkadas = new CrewMember("Imasa Okadas", CrewRole.TACTICAL, "17EDB1EA49444C603573DFB410B2C262");
            imasaOkadas.CrewStats.FireRate = 2f;
            imasaOkadas.CrewStats.TurretTraverse = 25f;
            CrewListing.Add(imasaOkadas);

            CrewMember julesValentine = new CrewMember("Jules Valentine", CrewRole.TACTICAL, "CC7A81AD4BB2E1BF90CEC1A3DAFAA373");
            julesValentine.CrewStats.FireRate = 2f;
            julesValentine.CrewStats.TurretTraverse = 25f;
            CrewListing.Add(julesValentine);

            CrewMember krystenTchaikovsky = new CrewMember("Krysten Tchaikovsky", CrewRole.TACTICAL, "50BECA4949A2848119822E82226063C1");
            krystenTchaikovsky.CrewStats.FireRate = 2f;
            krystenTchaikovsky.CrewStats.TurretTraverse = 25f;
            CrewListing.Add(krystenTchaikovsky);

            CrewMember tauIs= new CrewMember("TAU-IS", CrewRole.TACTICAL, "57B7C1F84E93CC90B5790383F7ABAD18");
            tauIs.CrewStats.FireRate = 4f;
            tauIs.CrewStats.TurretTraverse = 12.5f;
            CrewListing.Add(tauIs);

            CrewMember xeridGreyFist = new CrewMember("Xerid Greyfist", CrewRole.TACTICAL, "57B7C1F84E93CC90B5790383F7ABAD18");
            xeridGreyFist.CrewStats.FireRate = 3f;
            xeridGreyFist.CrewStats.TurretTraverse = 18.75f;
            CrewListing.Add(xeridGreyFist);

            // ##### UTILITY #####

            CrewMember grinczMorrow = new CrewMember("Grincz Morrow", CrewRole.UTILITY, "ADB48C2049AD7E235ABB47818BBBA283");
            grinczMorrow.CrewStats.EnergyEfficiency = 5.63f;
            grinczMorrow.CrewStats.UtilityCooldown = -5.62f;
            CrewListing.Add(grinczMorrow);

            CrewMember ludologist = new CrewMember("Ludologist", CrewRole.UTILITY, "5E0EC5464C707BD2491991B3031EC524");
            ludologist.CrewStats.EnergyEfficiency = 3.75f;
            ludologist.CrewStats.UtilityCooldown = -7.5f;
            CrewListing.Add(ludologist);

            CrewMember palam0n = new CrewMember("Palam0n", CrewRole.UTILITY, "555DCF064663C9470A03AD89978A710B");
            palam0n.CrewStats.EnergyEfficiency = 3.75f;
            palam0n.CrewStats.UtilityCooldown = -7.5f;
            CrewListing.Add(palam0n);

            CrewMember regan = new CrewMember("Regan", CrewRole.UTILITY, "C695059E4356F317E1A3F1B4A33107C2");
            regan.CrewStats.EnergyEfficiency = 5.63f;
            regan.CrewStats.UtilityCooldown = -5.62f;
            CrewListing.Add(regan);

            CrewMember seraphineVega = new CrewMember("Seraphine Vega", CrewRole.UTILITY, "FFEE8C2E420D6F18592FC7BD4A33070E");
            seraphineVega.CrewStats.EnergyEfficiency = 5.63f;
            seraphineVega.CrewStats.UtilityCooldown = -5.62f;
            CrewListing.Add(seraphineVega);

            CrewMember zhangTao = new CrewMember("Zhang Tao", CrewRole.UTILITY, "0473AF5C437B066B20F23383B826D8CF");
            zhangTao.CrewStats.EnergyEfficiency = 7.5f;
            zhangTao.CrewStats.UtilityCooldown = -3.75f;
            CrewListing.Add(zhangTao);
        }
    }
}
