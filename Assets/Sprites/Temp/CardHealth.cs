using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardHealth : MonoBehaviour
{
    public float lifeCount = 4f;
    float currentLifeCount;
    public TextMeshPro lifeCountText;

    void Start()
    {
        currentLifeCount = lifeCount;
        lifeCountText.text = currentLifeCount.ToString();
    }

    public void TakeDamage(float amt)
    {
        currentLifeCount -= amt;
        lifeCountText.text = currentLifeCount.ToString();

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
