using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public GameObject gameOverScreen;

    public void restartGame()
    {
        EnemyScript.enemyCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void returnMenu()
    {
        SceneManager.LoadSceneAsync("menuPage");
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
