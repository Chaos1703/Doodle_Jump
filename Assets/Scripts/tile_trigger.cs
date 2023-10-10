using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile_trigger : MonoBehaviour
{
    public bool tophit;
    void Start()
    {
        tophit = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        tophit = true;
    }
}
