using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToOtherScene(string SceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }

    public void MoveToOtherScene(int SceneNumber)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneNumber);
    }

    public void QuitGame()
    {
        Debug.Log("Exit Game");
        Application.Quit();
    }
}
