using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MaxHealth;
    public float MaxSpeed;
    public GameObject PlayerModel;

    void Update()
    {

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("Move Forward");
        }
    }
}
