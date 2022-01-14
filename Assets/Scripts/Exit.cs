using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public KeyCode restartKey;
    public KeyCode quitKey;

    void Update()
    {
        if (Input.GetKeyDown(quitKey))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(restartKey))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}