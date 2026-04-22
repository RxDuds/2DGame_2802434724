using UnityEngine;

public class GameManager : MonoBehaviour
{
    public string nextlevelname;
    public void nextLevel()
    {
        Debug.Log("NextScene");
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextlevelname);
        Time.timeScale = 1f;
    }

    public void Startlevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
