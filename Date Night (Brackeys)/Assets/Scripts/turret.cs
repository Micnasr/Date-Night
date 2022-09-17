using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{

    float timer;
    public GameObject bullet;
    public float speed;

    GameObject clone;
    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= speed)
        {
            clone = Instantiate(bullet, transform.position, Quaternion.identity);
            timer = 0f;

        }
    }

}
