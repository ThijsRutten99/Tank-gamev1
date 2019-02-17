using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int Reach;
    // Start is called before the first frame update
    void Start()
    {

        Reach = 10;
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Input.GetButton("Fire1"))
        {
            var fwd = transform.TransformDirection(Vector3.up);

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * Reach);
            
            if (Physics.Raycast(transform.position, fwd, out hit, Reach) && hit.transform.gameObject.tag == "Target")
            {
                Debug.Log(hit.collider.gameObject.name);
                Destroy(hit.transform.gameObject);
            }

        }

    }
}
