using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Spawning : MonoBehaviour
{
    public GameObject[] level1_tiles = new GameObject[3];
    private int[] rarity = {1, 3, 6};
    private int[] rarity_check = {0,0,0};
    private int number_of_tiles = 200;
    private float left_width = 17.15f;
    private float right_width = -15.34f;
    private int count = 0;
    private float mini_y = 0.5f;
    private float maxi_y = 2f;

    void Start()
    {
        Vector3 spawn_posi = new Vector3(0,-6,0);
        while(count < number_of_tiles){
            int temp = UnityEngine.Random.Range(0,3);
            rarity_check[temp]++;
            if(rarity_check[temp] >= rarity[temp]){
                rarity_check[temp] = 0;
                spawn_posi.y += UnityEngine.Random.Range(mini_y , maxi_y);
                spawn_posi.x = UnityEngine.Random.Range(left_width , right_width);
                Instantiate(level1_tiles[temp] , spawn_posi , Quaternion.identity);
                count++;
            }
        }
    }

}