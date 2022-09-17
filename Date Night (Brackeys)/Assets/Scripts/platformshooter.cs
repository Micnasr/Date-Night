using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformshooter : MonoBehaviour
{

    public GameObject up;
    public GameObject down;

    public GameObject BluePlatform;
    public GameObject PinkPlatform;

    float timer;


    int randomnum;
    int randomnum2;
    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            randomnum = Random.Range(0, 2);
            randomnum2 = Random.Range(0, 2);

            if (randomnum == 0)
            {
                if (randomnum2 == 0)
                {
                    Instantiate(BluePlatform, up.transform.position, Quaternion.identity);
                } else if (randomnum2 == 1)
                {
                    Instantiate(BluePlatform, down.transform.position, Quaternion.identity);
                }
                
            } else if (randomnum == 1)
            {
                if (randomnum2 == 0)
                {
                    Instantiate(PinkPlatform, up.transform.position, Quaternion.identity);
                }
                else if (randomnum2 == 1)
                {
                    Instantiate(PinkPlatform, down.transform.position, Quaternion.identity);
                }
            }
            timer = 0f;

        }
    }
}
