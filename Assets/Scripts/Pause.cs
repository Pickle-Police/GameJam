using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public KeyCode pauseKey;

    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            SceneManager.LoadScene("Title Screen");
        }
    }
}
