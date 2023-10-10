using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform target;
    public float smoothspeed = 0.7f;

    void LateUpdate()
    {
        if(target.position.y > transform.position.y){
            Vector3 newPosi = new Vector3(transform.position.x , target.position.y , transform.position.z);
            transform.position = Vector3.Lerp(transform.position , newPosi , smoothspeed*Time.deltaTime);
        }
    }
}
