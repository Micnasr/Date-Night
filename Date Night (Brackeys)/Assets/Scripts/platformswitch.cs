using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformswitch : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
           Debug.Log("player1");
            transform.gameObject.layer = 9;
            gameObject.GetComponent<SpriteRenderer>().material.color = Color.cyan;

        } else if (collision.gameObject.tag == "player2")
        {
            Debug.Log("player2");
            transform.gameObject.layer = 10;
            gameObject.GetComponent<SpriteRenderer>().material.color = Color.magenta;


        }
    }
}
