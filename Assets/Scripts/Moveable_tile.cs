using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable_tile : MonoBehaviour
{
    private Rigidbody2D tile;

    private float move_speed;

    void Start()
    {
        tile = GetComponent<Rigidbody2D>();
        move_speed = 10f;
    }

    void Update()
    {
        tile.velocity = new Vector2(move_speed , tile.velocity.y);
        change();
    }

    void change()
    {
        if(transform.position.x <= -15.4f)
            move_speed = 10f;
        if(transform.position.x >= 15.4f)
            move_speed = -10f;
    }
}
