using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    //Publics
    public enum LevelType{
        PlaceholderEasy,
        PlaceholderMed,
        PlaceholderHard
    }

    //Privates
    private RoomBuilder roomBuilder;

    public void GenerateLevel(LevelType levelType)
    {
        Level level = new Level();
        level.Type = levelType;
        Debug.Log(string.Format("Generating level of type: {0}", level.Type));

        List<GameObject> rooms;

        switch (level.Type)
        {
            case LevelType.PlaceholderEasy:
                rooms = GetComponent<Rooms>().EasyRooms;
                foreach(var room in rooms)
                {
                    var tRoom = Instantiate(room);
                    tRoom.name = "Easy Room";
                }
                break;
            case LevelType.PlaceholderHard:
                break;
            default:
                break;
        }
    }
}
