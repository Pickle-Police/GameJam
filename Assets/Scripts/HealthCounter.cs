using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCounter : MonoBehaviour
{
    private var lifeCount : private object guiGO;

    public object LifeCount { get => lifeCount; set => lifeCount = value; }

    int = 4;
    public guiGO : GUIText;
    function DecrementLife ()
    {
        --lifeCount;
        guiGO.text = lifeCount;
    }
}
