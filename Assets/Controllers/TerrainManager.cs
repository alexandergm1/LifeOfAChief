using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
 
    public Terrain m_terrain;  
    public float DrawDistance; 
 
    void Start () {
 
        m_terrain.detailObjectDistance = DrawDistance;
        
    }
}
