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
        Debug.Log("detect click");
        Vector3 pos = PlayerArea.transform.position;
        GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], pos, Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, true);
        
    }

  
}

 