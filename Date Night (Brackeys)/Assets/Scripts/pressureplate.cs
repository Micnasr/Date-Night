using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureplate : MonoBehaviour
{

    public GameObject platformer;
    public GameObject location;

    bool on = false;
    GameObject clone;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (on == false)
        {
            on = true;
            clone = Instantiate(platformer, location.transform.position, Quaternion.identity);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (on == true)
        {
            on = false;
            Destroy(clone);
        }
    }
}