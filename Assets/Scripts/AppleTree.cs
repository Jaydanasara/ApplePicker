using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in inspector")]

    // prefab instantiating apples
    public GameObject applePrefab;

    // Speed at which the apple tree moves
        public float  speed = 1f;

    // distance where apple tree turns arround
    public float leftAndRightEdge = 10f ;

    // chance that apple tree will change directions 

    public float chanceToChangeDirections = 0.1f;

    // rate at wich apples will be instantiated 
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {                                    
       
    }

    // Update is called once per frame
    void Update(){                                             //a             
         //Basic movement 
        Vector3 pos= transform.position;                       //b
        pos.x += speed * Time.deltaTime;                       //c
        transform.position = pos;                              //d

        //changing direction
        if (pos.x < -leftAndRightEdge){                          //a
            speed = Mathf.Abs (speed); // Move right             //b
        } else if (pos.x > leftAndRightEdge) {                   //c
            speed = -Mathf.Abs(speed); // Move left              //c
        }
    }
    void FixedUpdate(){
         if (Random.value < chanceToChangeDirections){
            speed *= -1; // change direction
        }

    }


}
