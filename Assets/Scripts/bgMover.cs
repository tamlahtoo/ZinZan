using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMover : MonoBehaviour
{
    public GameObject posObj;
    private Vector3 pos;
    void Start()
    {
        pos = posObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bgMover"))
        {
            transform.position = pos;
        }
    }

  
}
