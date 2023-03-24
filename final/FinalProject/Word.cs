using System;

public class Word
{
    protected string _TownName;
    public string[] _TownNames = {"Skystead", "Yarrin", "Fjordton", "Haling Cove", "Lockwood Village", "Daekrahm Village", "Old Begtuok", "Lumina Village", "Tarnstead Outpost", "Aygisth Village", "Western Solaris", "Warchester Town", "Akriel Town", "Glimmer Villa", "Town of Ebba", "Sky Port"};
    protected string _CityType;
    public string[] _CityTypes = {"Coastal", "Forested", "Cliffside", "Port", "Mountain", "Underground", "Desert", "Frozen Tundra", "Taiga", "Rain Forested", "Grassland", "Savanna", "Underwater", "Swamp"};
    protected string _Location;
    public string[] _Locations = {"Mine", "Ruin", "Haunted House", "Camp", "School", "Temples", "Fortress", "Castle", "Dungeon", "Road", "Bridge", "Ferry", "Inn", "Tavern", "Port", "Saloon", "Prison", "Shop", "Church", "Bathhouse", "Library", "Arena", "Auction", "Party", "Performance", "Healers", "Brawl", "Tea Shop", "Forest", "Festival", "Watch duty"};
    protected string _Name;
    public string[] _Names = {"Raven", "Brona", "Lorelai", "Alastair", "Azazel", "Jabez", "Sable", "Hades", "Odon", "Typhon", "Adrielle", "Thanatos", "Revon", "Kol", "Nyx", "Vlasta", "Keres", "Kuraim", "Ozul"};
    protected string _Item;
    public string[] _Items = {"Door of Delusion", "Gloves of Resurrection", "Eternity Crown", "Mask of Vengeance", "Tablet of Karma", "Pillar of Invincibility", "Fire Chalice"};

    public void setTownName(string TownName)
    {
        _TownName = TownName;
    }
    public string getTownName()
    {
     return _TownName;
    }
    public void setTownNameRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_TownNames.Count());
        _TownName = _TownNames[num];
    }
    public string[] getTownNames()
    {
     return _TownNames;
    }
    public void setCityType(string CityType)
    {
        _CityType = CityType;
    }
    public string getCityType()
    {
     return _CityType;
    }
    public void setCityTypeRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_CityTypes.Count());
        _CityType = _CityTypes[num];
    }
    public string[] getCityTypes()
    {
     return _CityTypes;
    }
    public void setLocation(string Location)
    {
        _Location = Location;
    }
    public string getLocation()
    {
     return _Location;
    }
    public void setLocationRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_Locations.Count());
        _Location = _Locations[num];
    }
    public string[] getLocations()
    {
     return _Locations;
    }
    public void setName(string Name)
    {
        _Name = Name;
    }
    public string getName()
    {
     return _Name;
    }
    public void setNameRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_Names.Count());
        _Name = _Names[num];
    }
    public string[] getNames()
    {
     return _Names;
    }
    public void setItem(string Item)
    {
        _Item = Item;
    }
    public string getItem()
    {
     return _Item;
    }
    public void setItemRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_Items.Count());
        _Item = _Items[num];
    }
    public string[] getItems()
    {
     return _Items;
    }
}