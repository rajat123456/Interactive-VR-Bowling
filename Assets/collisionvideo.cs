using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionvideo : MonoBehaviour
{

  
    // Update is called once per frame
    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player"))
            SceneManager.LoadScene(1);
       
    }
}
