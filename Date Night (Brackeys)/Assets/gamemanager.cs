using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject dead;

    float timer;

    // Update is called once per frame
    void Update()
    {
        if (dead.tag == "true")
        {
            Debug.Log("working");

            timer += Time.deltaTime;
            if (timer >= 2f)
            {
                Dead();

            }
        }
    }


    void Dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
