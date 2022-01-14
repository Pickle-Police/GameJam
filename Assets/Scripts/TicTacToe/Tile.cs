//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Tile : MonoBehaviour 
//{ 
//    public static Owner currentPlayersTurn = Owner.Player1;

//    public enum Owner {  None, Player1, Player2 }
//    public Owner owner = Owner.None; 
//    public GameObject XPrefab; 
//    public GameObject OPrefab;

//    private bool IsHovered = false; 

//    private void Start()
//    {
//        currentPlayersTurn = Owner.Player1;
//    } 

//    private void Update()
//    {
//        if (GameManager.Winner) return;

//        if (IsHovered && Input.GetMouseButtonDown(0) && owner == Owner.None)
//        {
//            owner = currentPlayersTurn;

//            if (currentPlayersTurn == Owner.Player1)
//            {
//                SpawnSymbol(XPrefab);
//                currentPlayersTurn = Owner.Player2;
//            }
//            else if (currentPlayersTurn == Owner.Player2)
//            {
//                SpawnSymbol(OPrefab);
//                currentPlayersTurn = Owner.Player1;
//            }
//        }
//    }

//    private void OnMouseEnter()
//    {
//        IsHovered = true;
//    }

//    private void OnMouseExit()
//    {
//        IsHovered = false;
//    }

//    private void SpawnSymbol(GameObject _object)
//    {
//        Instantiate(_object, transform.position, Quaternion.identity);
//    }
//}
