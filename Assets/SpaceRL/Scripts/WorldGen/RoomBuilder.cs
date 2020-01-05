using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Room;

public class Room
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

    public RoomType Type { get; set; }
}

public class RoomBuilder : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BuildRoom(Room room)
    {
        switch (room.Type)
        {
            case RoomType.BossRoom:
                //Check if a BossRoom has already been rendered in the room
                break;
            case RoomType.Standard:
                //Should be fine, no limit on standard rooms
                break;
            case RoomType.Shop:
                //Probably only want one shop on each floor
                break;
            case RoomType.Chance:
                //Max one per floor, sometimes not even?
                break;
            case RoomType.BossTreasure:
                //Only one and can only be touching the boss room
                break;
            case RoomType.Treasure:
                //Only one per floor
                break;
            case RoomType.Secret:
                //No door but also no obstacles
                break;
        }
    }
}
