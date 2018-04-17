using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    // Start
    public void ButtonStart()
    {
        SceneManager.LoadScene("SceneTest");
    }

    // Restart
    public void ButtonRestart()
    {
        SceneManager.LoadScene(0);
    }

    // Exit
    public void ButtonExit()
    {
        Application.Quit();
    }

	
}
