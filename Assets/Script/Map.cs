using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    public List<Village> Villages { get; set;}
    public List<Castle> Castles { get; set;}
    public static Map Instance { get; private set;}

    public Map()
    {
        this.Villages = new List<Village>();
        this.Castles = new List<Castle>();
    }

    public static Map InitializeMap()
    {
        Map map = new Map();
        map.AddVillage(Village.InitializeVillage1());
        map.AddVillage(Village.InitializeVillage2());
        map.AddVillage(Village.InitializeVillage3());
        map.AddCastle(Castle.InitializeStartingCastle());
        Instance = map;
        return Instance;
    }

    public void AddCastle(Castle castle)
    {
        this.Castles.Add(castle);
    }

    public void AddVillage(Village village)
    {
        this.Villages.Add(village);
    }

    public Village FindVillageByName(string name)
    {
        foreach (Village village in Villages)
        {
            if (village.Name == name) return village;
        }
        return null;
    }


}
