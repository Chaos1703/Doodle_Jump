using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable_tile : MonoBehaviour 
{
    public tile_trigger Tile;
    private Animator animator;
    private Rigidbody2D tile;
     void Awake()
     {
        animator = GetComponent<Animator>();
        tile = GetComponent<Rigidbody2D>();
     }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player" && Tile.tophit == true){
            animator.Play("Tile_Breaking");
            StartCoroutine (break_tile());
        }
    }

    IEnumerator break_tile(){
        yield return new WaitForSeconds(0.6f);
        Destroy(gameObject);
    }

    void stop_Animation(){
        animator.speed = 0;
        tile.bodyType = RigidbodyType2D.Dynamic;
    }
}
