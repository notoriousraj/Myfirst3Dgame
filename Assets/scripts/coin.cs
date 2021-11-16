using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float rotatespeed = 180;

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(Vector3.up ,rotatespeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<player>().Addscore(1);
            Destroy(gameObject);
        }

    }
}
