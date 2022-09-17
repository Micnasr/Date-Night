using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazerswitch : MonoBehaviour
{
    public GameObject lazer;
    public GameObject location;
    GameObject clone;
    bool on = false;
    GameObject original;
    bool orig = true;
    private void Start()
    {
        original = Instantiate(lazer, location.transform.position, Quaternion.identity);
    }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(original);
        if (on == true)
        {
            on = false;
            Destroy(clone);
            
        }
            
        
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (on == false)
        {
            on = true;
            clone = Instantiate(lazer, location.transform.position, Quaternion.identity);
        }
    }

}
