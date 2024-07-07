using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectLevelMangager : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadSceneAsync("menuPage");
    }

    public void levelOne()
    {
        SceneManager.LoadSceneAsync("levelOne");
    }

    public void levelTwo()
    {
        SceneManager.LoadSceneAsync("levelTwo");
    }

    public void levelThree()
    {
        SceneManager.LoadSceneAsync("levelThree");
    }
}
