using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winningplatform : MonoBehaviour
{
    int bluecounter = 0;
    int pinkcounter = 0;
    float timer;

    public GameObject WinParticle;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (bluecounter == pinkcounter && bluecounter > 0)
        {
            Instantiate(WinParticle, transform.position, Quaternion.identity);

            timer += Time.deltaTime;
            if (timer >= 2f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("Working");

                

            }

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            bluecounter = 1;
            
        }
        else if (collision.gameObject.tag == "player2")
        {
            pinkcounter = 1;
            
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            bluecounter = 0;

        }
        else if (collision.gameObject.tag == "player2")
        {
            pinkcounter = 0;

        }
    }

}

