using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage : MonoBehaviour
{
    public void S0()
    {
        SceneManager.LoadScene("level0");
    }
    public void S1()
    {
        SceneManager.LoadScene("level1");
    }
    public void S2()
    {
        SceneManager.LoadScene("level2");
    }
    public void S3()
    {
        SceneManager.LoadScene("level3");
    }
    public void S4()
    {
        SceneManager.LoadScene("level4");
    }
}
