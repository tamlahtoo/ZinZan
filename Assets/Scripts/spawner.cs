using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] ObstaclesPatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public GameObject player;
    public Player[] no;
    public int score;
    public GameObject ghost;
    public int scoreValue;


    private void Start()
    {
        no = player.GetComponents<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue = GameObject.FindWithTag("Player").GetComponent<Player>().scoreValue;
        if (scoreValue >= 15)
        {
            startTimeBtwSpawn = 0.5f;
        }
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, ObstaclesPatterns.Length);
            Instantiate(ObstaclesPatterns[rand],  transform.position, Quaternion.identity);
           // Instantiate(spirit, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
       
    }
}
