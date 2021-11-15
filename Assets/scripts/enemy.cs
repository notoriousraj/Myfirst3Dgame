using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed = 2;
    public Vector3 movedirection;
    public float movedistance = 2;

    Vector3 startpos;
    bool movingtostart;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if (movingtostart)
        {
            transform.position = Vector3.MoveTowards(transform.position, startpos, speed * Time.deltaTime);
            if(transform.position == startpos)
            {
                movingtostart = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startpos + (movedirection * movedistance), speed * Time.deltaTime);
            if(transform.position == startpos + (movedistance * movedirection))
            {
                movingtostart = true;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<player>().Gameover();
        }
    }
}
