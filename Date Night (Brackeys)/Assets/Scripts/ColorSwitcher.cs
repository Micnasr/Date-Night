using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{

    float timer;

    private void Start()
    {
        transform.gameObject.layer = 10;
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.magenta;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            Blue();
            
        } 

        if (timer >= 2f)
        {
            Pink();
            timer = 0f;
        }
    }

    private void Blue()
    {
        transform.gameObject.layer = 9;
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.cyan;
    }

    private void Pink()
    {
        transform.gameObject.layer = 10;
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.magenta;
    }
    
}
