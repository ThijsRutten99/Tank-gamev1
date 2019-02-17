using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float rotateSpeed = 20.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
           float rotation =  rotateSpeed;

            rotation *= Time.deltaTime;

            transform.Rotate(0, rotation, 0);
        }
        if (Input.GetButton("Fire3"))
        {
            float rotation = rotateSpeed;

            rotation *= Time.deltaTime;

            transform.Rotate(0, -rotation, 0);
        }
    }
}
