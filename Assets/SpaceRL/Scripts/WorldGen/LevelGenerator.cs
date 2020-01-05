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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateLevel(LevelType level)
    {
        Debug.Log(string.Format("Would be generating level of type: {0}", level));
    }
}
