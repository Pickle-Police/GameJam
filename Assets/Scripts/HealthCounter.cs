using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCounter : MonoBehaviour
{
    public float lifeCount = 20f;
    float currentLifeCount;
    public Text lifeCountText;

    void Start()
    {
        currentLifeCount = lifeCount;
        lifeCountText.text = "Health: " + currentLifeCount.ToString();
    }

    public void TakeDamage(float amt)
    {
        currentLifeCount -= amt;
        lifeCountText.text = "Health: " + currentLifeCount.ToString();

        if (currentLifeCount <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
