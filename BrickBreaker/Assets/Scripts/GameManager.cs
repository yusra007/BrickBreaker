using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isRestart = false;
    ball ball;
    public void restartGame()
    {
        isRestart = true;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        
    }


    public void quitGame()
    {
        Application.Quit();
    }
 
    
}
