using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LevelGenerator;


public class WorldController : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelType level;

    private Vector3 root = new Vector3(0,0,0);

    void Start()
    {
        var generator = new LevelGenerator();
        generator.GenerateLevel(level);
        var player = Instantiate(GetComponent<Player>().PlayerModel);
        player.transform.position = root;
        player.name = "Player";
    }
}
