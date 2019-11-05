using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadCredits()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }

    public void loadGameplay()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void loadHome()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void exitGame()
    {
        Debug.Log("Confirm quit");
        Application.Quit();
    }
}
