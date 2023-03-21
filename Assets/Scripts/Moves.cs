using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    // public GameObject obj;
    public float moveSpeed = 3f, turnSpeed = 40f;

    //check speed for boost
    void checkSpeed(){
        if (Input.GetKey(KeyCode.Space)){
                moveSpeed*=3f;
            }
    }
    void Update()
    {
        //player's movement (17-36)
        if (Input.GetKey(KeyCode.W)){
            checkSpeed();
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            moveSpeed = 3f;
        }
        if (Input.GetKey(KeyCode.S)){
            checkSpeed();
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
            moveSpeed = 3f;
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
        //if (Input.GetKey(KeyCode.SPACE)){
          //  obj.transform.
        //}
    }
}
