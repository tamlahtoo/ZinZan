using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public int color;
    public int scoreValue = 0;
    public Text score;
    public bool white = true;
    public float speed;

    private Animator anim;

    public Text highScore;
    private int highscore;

    public GameObject spawn;
    private float setSpawn;

    public AudioSource colliderSound;

    public GameObject effectWhite;
    public GameObject effectBlack;


    void Start()    
    {   highscore = PlayerPrefs.GetInt("highscore");
        anim = GetComponent<Animator>();
        highScore.text = "High Score: " +highscore.ToString();
        setSpawn = spawn.GetComponent<spawner>().startTimeBtwSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        //change animation
        if (white == false)
        {
            anim.SetBool("isBlack", true);
        }
        else
        {
            anim.SetBool("isBlack", false);
        }

        //move player
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y !=3)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -3)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }

        

        //update score
        score.text = "Score: " + scoreValue;


        //making the game faster


        if (scoreValue > 4)
        {
            // spawn.GetComponent<spawner>().startTimeBtwSpawn = 0.6f;
           
        }


    }
    //button for andorid
    public void goUp()
    {
        if (transform.position.y != 3)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
    }

    public void goDown()
    {
        if (transform.position.y != -3)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("ghost"))
        {            
            if (white == true)
            {
               // Instantiate(effectBlack, transform.position, Quaternion.identity);
                colliderSound.Play();
                color += 1;
                scoreValue += 1;
                if (color == 6)
                {
                    white = false;
                }
            } else if (white == false)
            {
                //  churchBell.Play();
                // insert game over script
                //  Destroy(gameObject);
                PlayerPrefs.SetInt("score", scoreValue);
                SceneManager.LoadScene(sceneBuildIndex: 2);
                if (scoreValue > highscore)
                {
                    PlayerPrefs.SetInt("highscore", scoreValue);
                }
            }
        } else if (other.CompareTag("spirit")){
            

            if (white == false)
            {
              //  Instantiate(effectWhite, transform.position, Quaternion.identity);
                colliderSound.Play();
                color = color - 1;
                scoreValue += 1;
                if(color == 1)
                {
                    white = true;
                }
            } else if (white == true)
            {
                //  churchBell.Play();
                // insert game over script
                //  Destroy(gameObject);
                PlayerPrefs.SetInt("score", scoreValue);
                if (scoreValue > highscore)
                {
                    PlayerPrefs.SetInt("highscore", scoreValue);
                }
                SceneManager.LoadScene(sceneBuildIndex: 2);

            }
        }
    }
}
