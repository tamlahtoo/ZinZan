using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{
    public float speed ;
    public int scoreValue;
    public GameObject blackEffect;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // speed = GameObject.FindWithTag("speed").GetComponent<speed>().speedVar;
        transform.Translate(Vector2.left*speed);
        scoreValue = GameObject.FindWithTag("Player").GetComponent<Player>().scoreValue;
        if (scoreValue >= 15)
        {
            speed = 0.2f;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Instantiate(blackEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
       

    }
}
