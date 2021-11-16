using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public string nextlevel;
    public bool lastlevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(lastlevel == true)
            {
                 SceneManager.LoadScene(0);
            }
            else
            {
                 SceneManager.LoadScene(nextlevel);
            }
        }
    }
}
