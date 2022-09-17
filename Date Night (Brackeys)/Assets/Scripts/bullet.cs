using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject turret;
    float value = 0.01f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - value);
    }

    

}
