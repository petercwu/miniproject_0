using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
        public void startGame()
    {
        SceneManager.LoadSceneAsync("levelOne");
    }

    //     public void selectLevel()
    // {

    // }

        public void quit()
    {
        Application.Quit();
    }
}
