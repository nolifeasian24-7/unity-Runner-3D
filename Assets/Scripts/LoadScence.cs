using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScence : MonoBehaviour
{
   public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
