using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    float restartDelay = 1f;
    public GameObject completeLevelUi;

    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void success()
    {
        Debug.Log("Level Won");
    }
    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("game over");
            Invoke("restart", restartDelay);

        }
    }
    void restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
