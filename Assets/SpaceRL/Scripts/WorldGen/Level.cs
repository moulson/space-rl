using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LevelGenerator;

public class Room : MonoBehaviour
{   
    public enum RoomType
    {

        Standard = 0,
        Treasure = 1,
        Chance = 2,
        BossRoom = 3,
        BossTreasure = 4,
        Shop = 5,
        Secret = 6
    }

    public GameObject Floor { get; set; }
    public GameObject NorthWall { get; set; }
    public GameObject EastWall { get; set; }
    public GameObject SouthWall { get; set; }
    public GameObject WestWall { get; set; }
    public List<Enemy> Enemies { get; set; }
    public RoomType Type { get; set; }
}

public class Level
{
    public List<Room> Rooms { get; set; }
    public LevelType Type { get; set; }
}
