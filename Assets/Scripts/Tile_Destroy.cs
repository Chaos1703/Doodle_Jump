using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Destroy : MonoBehaviour
{
    private Transform camera;

    void Awake()
    {
        camera = Camera.main.transform;
    }

    void Update()
    {
        if(camera.position.y - 10.6f > transform.position.y){
            Destroy(gameObject);
        }
    }
}
