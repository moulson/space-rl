using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator
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
    }
}
