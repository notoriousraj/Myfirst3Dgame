using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float rotatespeed = 180;

    // Update is called once per frame
    void Update()
    {
        float angelrotation = rotatespeed * Time.deltaTime;
        transform.Rotate(Vector3.up * angelrotation  , Space.World);
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
