using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{
    public GameObject deck1;
    public GameObject PlayerArea;
    public GameObject EnemyArea;

    void Start()
    {
      
    }
    
    public void OnClick()
    {
        for (var i = 0; i < 5; i++)
        {
         GameObject playerCard = Instantiate(deck1, new Vector3(0, 0, 0), Quaternion.identity);
         playerCard.transform.SetParent(PlayerArea.transform, false);
        }
        
    }

    
}

 