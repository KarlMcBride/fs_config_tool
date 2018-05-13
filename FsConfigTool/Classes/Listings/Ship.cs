using System.Collections.Generic;

namespace FS_Config_Tool.Classes.Listings
{
    public enum ShipEnum
    {
        AEGIS,
        BASILISK,
        BLACK_WIDOW,
        BRAWLER,
        CENTURION,
        COLOSSUS,
        DETROYER,
        DISPLACER,
        DISRUPTOR,
        ENDEAVOUR,
        ENFORCER,
        EQUALISER,
        EXECUTIONER,
        GHOST,
        GLADIATOR,
        GUARDIAN,
        HUNTER,
        INFILTRATOR,
        INTERCEPTOR,
        LEVIATHAN,
        OVERSEER,
        PALADIN,
        PARAGON,
        PERSECUTOR,
        PIONEER,
        PROTECTOR,
        RAIDER,
        RANGER,
        RAVEN,
        REAPER,
        SENTINEL,
        SUPERLIFTER,
        VENTURER,
        WATCHMAN,
        // End of list
        END_OF_LIST
    }

    public struct Ship
    {
        public ShipEnum ID { get; private set; }
        public string Name { get; private set; }

        public Ship(ShipEnum id, string name)
        {
            ID = id;
            Name = (name.Equals("")) ? id.ToString() : name;
        }
    }

    public class ShipList
    {
        public static List<Ship> ShipListing;

        public static void PopulateShipList()
        {
            if (ShipListing != null)
            {
                return;
            }

            ShipListing = new List<Ship>();

            ShipListing.Add(new Ship(ShipEnum.AEGIS, "Aegis"));
            ShipListing.Add(new Ship(ShipEnum.BASILISK, "Basilisk"));
            ShipListing.Add(new Ship(ShipEnum.BLACK_WIDOW, "Black Widow"));
            ShipListing.Add(new Ship(ShipEnum.BRAWLER, "Brawler"));
            ShipListing.Add(new Ship(ShipEnum.CENTURION, "Centurion"));
            ShipListing.Add(new Ship(ShipEnum.COLOSSUS, "Colossus"));
            ShipListing.Add(new Ship(ShipEnum.DETROYER, "Destroyer"));
            ShipListing.Add(new Ship(ShipEnum.DISPLACER, "Displacer"));
            ShipListing.Add(new Ship(ShipEnum.DISRUPTOR, "Disruptor"));
            ShipListing.Add(new Ship(ShipEnum.ENDEAVOUR, "Endeavour"));
            ShipListing.Add(new Ship(ShipEnum.ENFORCER, "Enforcer"));
            ShipListing.Add(new Ship(ShipEnum.EQUALISER, "Equaliser"));
            ShipListing.Add(new Ship(ShipEnum.EXECUTIONER, "Executioner"));
            ShipListing.Add(new Ship(ShipEnum.GHOST, "Ghost"));
            ShipListing.Add(new Ship(ShipEnum.GLADIATOR, "Gladiator"));
            ShipListing.Add(new Ship(ShipEnum.GUARDIAN, "Guardian"));
            ShipListing.Add(new Ship(ShipEnum.HUNTER, "Hunter"));
            ShipListing.Add(new Ship(ShipEnum.INFILTRATOR, "Infiltrator"));
            ShipListing.Add(new Ship(ShipEnum.INTERCEPTOR, "Interceptor"));
            ShipListing.Add(new Ship(ShipEnum.LEVIATHAN, "Leviathan"));
            ShipListing.Add(new Ship(ShipEnum.OVERSEER, "Overseer"));
            ShipListing.Add(new Ship(ShipEnum.PALADIN, "Paladin"));
            ShipListing.Add(new Ship(ShipEnum.PARAGON, "Paragon"));
            ShipListing.Add(new Ship(ShipEnum.PERSECUTOR, "Persecutor"));
            ShipListing.Add(new Ship(ShipEnum.PIONEER, "Pioneer"));
            ShipListing.Add(new Ship(ShipEnum.PROTECTOR, "Protector"));
            ShipListing.Add(new Ship(ShipEnum.RAIDER, "Raider"));
            ShipListing.Add(new Ship(ShipEnum.RANGER, "Ranger"));
            ShipListing.Add(new Ship(ShipEnum.RAVEN, "Raven"));
            ShipListing.Add(new Ship(ShipEnum.REAPER, "Reaper"));
            ShipListing.Add(new Ship(ShipEnum.SENTINEL, "Sentinel"));
            ShipListing.Add(new Ship(ShipEnum.SUPERLIFTER, "Superlifter"));
            ShipListing.Add(new Ship(ShipEnum.VENTURER, "Venturer"));
            ShipListing.Add(new Ship(ShipEnum.WATCHMAN, "Watchman"));
        }
    }
}
