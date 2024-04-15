using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void Begin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Wat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelSelectionm()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void level4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
}
