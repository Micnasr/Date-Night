using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bluemoving : MonoBehaviour
{

    float value = 0.01f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - value, gameObject.transform.position.y);
    }
}
