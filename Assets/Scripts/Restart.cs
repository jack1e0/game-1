using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    
    
    
    public void restart()
    {
        
        SceneManager.LoadScene(0);
        ClickDoor.exit = false;
    }

    public void endGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
