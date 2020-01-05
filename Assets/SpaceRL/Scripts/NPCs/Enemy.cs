using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum EnemyType
    {
        Boss,
        Champ,
        Standard,
        Heavy
    }

    public float MaxHP { get; set; }
    public string Name { get; set; }
    public EnemyType Type { get; set; }

    private float CurrentHP { get; set; }
}
