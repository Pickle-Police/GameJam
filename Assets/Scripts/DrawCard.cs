using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    public GameObject PlayerArea;
    public GameObject EnemyArea;

    public GameObject DevitoCard;

    void Start()
    {
        cards.Add(DevitoCard);
    }
    
    public void OnClick()
    {
        for (var i = 0; i < 5; i++)
        {
         GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
         playerCard.transform.SetParent(PlayerArea.transform, false);
        }
        
    }

  
}

 