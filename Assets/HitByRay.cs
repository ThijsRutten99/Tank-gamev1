using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByRay : MonoBehaviour
{
    void HitbyRay()
    {
        Debug.Log("Hit a target");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, fwd, out hit, 10) && hit.transform.tag == "Target")
        {
            Debug.Log("Greaakt");
        }
    }
}
