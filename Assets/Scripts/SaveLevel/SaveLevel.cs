using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLevel : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("Level") && SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
            return;
        }

        PlayerPrefs.SetInt("Level", SceneManager.GetActiveScene().buildIndex);
    }
}