using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("detect click");
        Application.Quit();
    }
}
