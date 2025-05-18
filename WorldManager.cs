using UnityEngine;
using System.Collections.Generic;

public class WorldManager : MonoBehaviour
{
    public enum Region { Papasmurfstatu, Thestart, Handystatu, Greenland1 }

    public Dictionary<Region, bool[,]> regionGrid = new Dictionary<Region, bool[,]>();

    void Start()
    {
        InitializeRegions();
    }

    void InitializeRegions()
    {
        // Each region 10x10 grid: true = occupied, false = free
        foreach (Region region in System.Enum.GetValues(typeof(Region)))
        {
            regionGrid[region] = new bool[10, 10];
        }

        // Mark positions for PapaSmurfStatue in Papasmurfstatu (5,6), (5,5), (6,5), (6,6)
        SetOccupied(Region.Papasmurfstatu, new Vector2Int(5,6));
        SetOccupied(Region.Papasmurfstatu, new Vector2Int(5,5));
        SetOccupied(Region.Papasmurfstatu, new Vector2Int(6,5));
        SetOccupied(Region.Papasmurfstatu, new Vector2Int(6,6));

        // Mark position for HandyStatue in Handystatu (7,3)
        SetOccupied(Region.Handystatu, new Vector2Int(7,3));
    }

    public void SetOccupied(Region region, Vector2Int pos)
    {
        regionGrid[region][pos.x - 1, pos.y - 1] = true; // Adjusting index from 1-based to 0-based
    }

    public bool IsFree(Region region, Vector2Int pos)
    {
        return !regionGrid[region][pos.x - 1, pos.y - 1];
    }
}