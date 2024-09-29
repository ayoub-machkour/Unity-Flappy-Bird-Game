using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Myrigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            Myrigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y < -14 || transform.position.y > 14)
        {
            logic.gameOver(); 
            birdIsAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
