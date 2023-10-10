using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    public Text Score;
    public Canvas game_Over;
    public Transform camera;
    private float move_force  = 10f;
    private float jump_force = 30f;
    private bool is_Grounded;
    private Rigidbody2D player;
    private int old_Score = 0;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        is_Grounded = true;
    }

    void Update()
    {
        if(is_Grounded){
            jump();
        }
        move(Input.GetAxisRaw("Horizontal"));
        border(transform.position.x);

        update_score();

        if(camera.position.y - 11f > transform.position.y)
            death();

    }
    void jump(){
        player.velocity = new Vector2(player.velocity.x, jump_force);
        is_Grounded = false;
    }
    void move(float n){
        if(n == 1){
            player.velocity = new Vector2(move_force, player.velocity.y);
            transform.localScale = new Vector3(-1 , 1 , 1);
        }
        if(n == -1){
            player.velocity = new Vector2(-move_force, player.velocity.y);
            transform.localScale = new Vector3(1 , 1 , 1);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground"){
            is_Grounded = true;
        }
    }

    void border(float x){
        if(x <= -17.68f){
            transform.position = new Vector3(16.52f , transform.position.y , transform.position.z);
        }

        if(x >= 17.65f){
            transform.position = new Vector3(-16.97f , transform.position.y , transform.position.z);
        }
    }
    void update_score(){
        int new_Score;
        if(transform.position.y > 0)
            new_Score = ((int) transform.position.y * 10);
        else
            return;
        if(new_Score > old_Score){
            Score.text = "Score: " + new_Score;
            old_Score = new_Score;
        }
    }
    void death(){
        game_Over.gameObject.SetActive(true);
    }

    public void restart(){
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}