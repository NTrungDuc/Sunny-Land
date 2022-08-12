using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuControl : MonoBehaviour
{
    public Canvas Pause;
    public void pauseUI()
    {
        Pause.gameObject.SetActive(true);
        Time.timeScale = 0;
        AudioListener.volume = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1;
        Pause.gameObject.SetActive(false);
        AudioListener.volume = 1f;
    }
    public void Main()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("mainMenu");
        AudioListener.volume = 1f;
    }
    // Start is called before the first frame update
    public void playButton()
    {
        SceneManager.LoadScene("menuStage");
    }
    public void playAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        AudioListener.volume = 1f;
    }
    public void quitButton()
    {
        Application.Quit();
    }
}
