using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{ public GameObject[] stars;
public GameObject[] starElement;
public GameObject[] wallElement;
public GameObject[] ball;
 public float rotationSpeed =30f;
   public float scaleSpeed = 1f;
    public float moveSpeed = 2f;    
     void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(stars.Length >= 5){
            foreach(GameObject star in stars){
                 star.transform.Rotate(0, 0,rotationSpeed*Time.deltaTime);
            }
        }

        for(int i=0; i< starElement.Length;i++){
            if(i == 2 || i == 3){
                starElement[i].transform.Rotate(0, 0,-rotationSpeed*Time.deltaTime);
            }else{
                starElement[i].transform.Rotate(0, 0,rotationSpeed*Time.deltaTime);
            }
        }

        for(int i=0; i< wallElement.Length;i++){
            if(i == 2 || i == 4){
               float scale = Mathf.PingPong(Time.time*scaleSpeed,1.0f);
               Debug.Log(scale);
            wallElement[i].transform.Rotate(0,-rotationSpeed*Time.deltaTime, 0);

            }
            else{
                wallElement[i].transform.Rotate(0,rotationSpeed*Time.deltaTime, 0);
            }
        }

        
            float moveDirection = Mathf.PingPong(Time.time*moveSpeed,3f)+1f;
            ball[0].transform.position = new Vector3(ball[0].transform.position.x,ball[0].transform.position.y,moveDirection);
            ball[1].transform.position = new Vector3(moveDirection,ball[1].transform.position.y,ball[1].transform.position.z);

                  
        
    }
}
