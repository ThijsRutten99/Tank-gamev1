using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTank : MonoBehaviour
{
    float tankHeight;
    // Start is called before the first frame update
    void Start()
    {
        tankHeight = transform.lossyScale.y /2;
    }
    public float speed = 10.0f;
    // Update is called once per frame
    

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical axis.
        
        float MoveVertical = Input.GetAxis("Vertical") * speed;
        float MoveHorizontal = Input.GetAxis("Horizontal") * speed;
        
        // Make it move 10 meters per second instead of 10 meters per frame...
        MoveVertical *= Time.deltaTime;
        MoveHorizontal *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(MoveHorizontal, 0, MoveVertical);

        // detect plane 
    
        RaycastHit hit;
    
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
        {
            if (hit.distance < 1)
            {
                transform.position -= new Vector3(0, hit.distance - tankHeight, 0);
                transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation ;
               
            }
               }
        else
        {
            Debug.Log("Did not Hit");
        }
    }
}

