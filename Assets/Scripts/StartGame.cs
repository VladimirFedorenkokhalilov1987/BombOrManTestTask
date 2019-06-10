using System;
using System.Collections;
using System.Collections.Generic;
using Bomberman;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    private void Awake()
    {
        if (GameObject.Find("GameManager"))
        {
            Destroy(GameObject.Find("GameManager"));
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter)||Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
