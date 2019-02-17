using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int distance;
    // Start is called before the first frame update
    void Start()
    {
      
        distance = 10;
    }
    
    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Input.GetButton("Fire1")){
            var fwd = transform.TransformDirection(Vector3.up);
            
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * distance);
            if (Physics.Raycast(transform.position, fwd, out hit, distance) && hit.transform.gameObject.tag == "Target")
            {
                Destroy(hit.transform.gameObject);
            }

        }

        }
}
