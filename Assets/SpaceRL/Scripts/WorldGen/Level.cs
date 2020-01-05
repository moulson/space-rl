﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject Floor { get; set; }
    public GameObject NorthWall { get; set; }
    public GameObject EastWall { get; set; }
    public GameObject SouthWall { get; set; }
    public GameObject WestWall { get; set; }
    public List<Enemy> Enemies { get; set; }
}
