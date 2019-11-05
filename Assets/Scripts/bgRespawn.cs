using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgRespawn : MonoBehaviour
{
    public GameObject bgLayer;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bg1"))
        {

        }

    }
}
