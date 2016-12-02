using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void StartGame(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitGame(string name)
    {
        Application.Quit();
    }

    public void WinGame(string name)
    {
        SceneManager.LoadScene(name);
    }

}
