using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // public float scaleSpeed = 1.0f;
    // private Vector3 originalScale;
    public GameObject[] cubes;
    public float rotationSpeed =50.0f;
   public float scaleSpeed = 1.0f;
    public float moveSpeed = 2.0f; 
    void Start()
    {
        //  originalScale = transform.localScale;

    }

    void Update()
    {
        //transform.Rotate(0,30*Time.deltaTime,15*Time.deltaTime);
        // //?يكبر ويصغر
        // float scale = Mathf.PingPong(Time.time*scaleSpeed,1) + 1;
        // transform.localScale = originalScale * scale;

        // if(cubes.Length >=3){
        //     cubes[0].transform.Rotate(0, rotationSpeed*Time.deltaTime,rotationSpeed*Time.deltaTime);
        //     cubes[1].transform.Rotate(Vector3.up, rotationSpeed*Time.deltaTime);
        //     cubes[2].transform.Rotate(5f, 0,rotationSpeed*Time.deltaTime);

            // float scale = Mathf.PingPong(Time.time*scaleSpeed,1.0f) + 1.0f;
            // cubes[1].transform.localScale = new Vector3(scale,scale,scale);

            // float moveDirection = Mathf.PingPong(Time.time*moveSpeed,5.0f) + 1.0f;
            // cubes[2].transform.position = new Vector3(cubes[2].transform.position.x,moveDirection,cubes[2].transform.position.z);
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal,0, moveVertical);
        transform.Translate(movement*moveSpeed*Time.deltaTime);
        
    }
}
