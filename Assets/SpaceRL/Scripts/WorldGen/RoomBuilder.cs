using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Room;

public class RoomBuilder : MonoBehaviour
{
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
