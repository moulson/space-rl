using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LevelGenerator;

public class WorldController : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelType level;

    void Start()
    {
        LevelGenerator generator = new LevelGenerator();
        generator.GenerateLevel(level);
    }
}
