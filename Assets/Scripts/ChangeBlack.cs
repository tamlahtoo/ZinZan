using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBlack : MonoBehaviour
{
    private GameObject player;
    private Animator anim;
    // Start is called before the first frame update
    
    void Start()
    {
       // player = GameObject.FindWithTag("player");
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Player>().white == false)
        {
            anim.SetBool("isBlack", true);
        }
    }
}
