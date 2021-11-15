using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed = 2;

    public Rigidbody rig;
    public float jumpforce = 5;
    private bool isgrounded;

    public int score;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rig.velocity = new Vector3(x * speed, rig.velocity.y, z * speed);

        Vector3 vel = rig.velocity;
        vel.y = 0;

        if(vel.x != 0 || vel.z !=0)
        {
            transform.forward = vel;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded == true) 
        {
            isgrounded = false;
            rig.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }

        if(transform.position.y < -5)
        {
            Gameover();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal == Vector3.up)
        {
            isgrounded = true;
        }
    }

    public void Gameover()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Addscore(int amount)
    {
        score += amount;
    }
}
