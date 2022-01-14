//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class GameManager : MonoBehaviour
//{
//    public static bool Winner = false;
     
//    public Text turnText;
//    public Text winnerText;
//    public GameObject winnerPanel;
//    public List<Tile> Tiles = new List<Tile>();

//    void Start() 
//    {
//        Winner = false; 
//    }

//    void Update()
//    {
//        if (Tile.currentPlayersTurn == Tile.Owner.Player1) turnText.text = "Player 1's Turn*";
//        else if (Tile.currentPlayersTurn == Tile.Owner.Player2) turnText.text = "Player 2's Turn";

//        //Tile setup:
//        //0 1 2
//        //3 4 5
//        //6 7 8 

//        #region Player 1 Win Conditions
//        if (Tiles[0].owner == Tile.Owner.Player1 && Tiles[1].owner == Tile.Owner.Player1 && Tiles[2].owner == Tile.Owner.Player1)
//            Player1Win();
//        else if (Tiles[3].owner == Tile.Owner.Player1 && Tiles[4].owner == Tile.Owner.Player1 && Tiles[5].owner == Tile.Owner.Player1)
//        Player1Win();
//        else if (Tiles[6].owner == Tile.Owner.Player1 && Tiles[7].owner == Tile.Owner.Player1 && Tiles[8].owner == Tile.Owner.Player1)
//            Player1Win();
//        else if (Tiles[0].owner == Tile.Owner.Player1 && Tiles[3].owner == Tile.Owner.Player1 && Tiles[6].owner == Tile.Owner.Player1)
//            Player1Win();
//        else if (Tiles[1].owner == Tile.Owner.Player1 && Tiles[4].owner == Tile.Owner.Player1 && Tiles[7].owner == Tile.Owner.Player1)
//            Player1Win();
//        else if (Tiles[2].owner == Tile.Owner.Player1 && Tiles[5].owner == Tile.Owner.Player1 && Tiles[8].owner == Tile.Owner.Player1)
//            Player1Win();
//        else if (Tiles[0].owner == Tile.Owner.Player1 && Tiles[4].owner == Tile.Owner.Player1 && Tiles[8].owner == Tile.Owner.Player1)
//            Player1Win();
//        else if (Tiles[2].owner == Tile.Owner.Player1 && Tiles[4].owner == Tile.Owner.Player1 && Tiles[6].owner == Tile.Owner.Player1)
//            Player1Win();
//        #endregion
//        #region Player 2 Win Condition
//        else if (Tiles[0].owner == Tile.Owner.Player2 && Tiles[1].owner == Tile.Owner.Player2 && Tiles[2].owner == Tile.Owner.Player2)
//            Player2Win();
//        else if (Tiles[3].owner == Tile.Owner.Player2 && Tiles[4].owner == Tile.Owner.Player2 && Tiles[5].owner == Tile.Owner.Player2)
//            Player2Win();
//        else if (Tiles[6].owner == Tile.Owner.Player2 && Tiles[7].owner == Tile.Owner.Player2 && Tiles[8].owner == Tile.Owner.Player2)
//            Player2Win();
//        else if (Tiles[0].owner == Tile.Owner.Player2 && Tiles[3].owner == Tile.Owner.Player2 && Tiles[6].owner == Tile.Owner.Player2)
//            Player2Win();
//        else if (Tiles[1].owner == Tile.Owner.Player2 && Tiles[4].owner == Tile.Owner.Player2 && Tiles[7].owner == Tile.Owner.Player2)
//            Player2Win();
//        else if (Tiles[2].owner == Tile.Owner.Player2 && Tiles[5].owner == Tile.Owner.Player2 && Tiles[8].owner == Tile.Owner.Player2)
//            Player2Win();
//        else if (Tiles[0].owner == Tile.Owner.Player2 && Tiles[4].owner == Tile.Owner.Player2 && Tiles[8].owner == Tile.Owner.Player2)
//            Player2Win();
//        else if (Tiles[2].owner == Tile.Owner.Player2 && Tiles[4].owner == Tile.Owner.Player2 && Tiles[6].owner == Tile.Owner.Player2)
//            Player2Win();
//        #endregion
//        #region Draw
//        else if (Tiles[0].owner != Tile.Owner.None && Tiles[1].owner != Tile.Owner.None && Tiles[2].owner != Tile.Owner.None &&
//            Tiles[3].owner != Tile.Owner.None && Tiles[4].owner != Tile.Owner.None && Tiles[5].owner != Tile.Owner.None &&
//            Tiles[6].owner != Tile.Owner.None && Tiles[7].owner != Tile.Owner.None && Tiles[8].owner != Tile.Owner.None)
//            PlayerDraw();
//        #endregion
//    }

//    private void Player1Win()
//    {
//        winnerText.text = "Player 1 Wins!";
//        winnerPanel.SetActive(true);
//        Winner = true;
//    }

//    private void Player2Win()
//    {
//        winnerText.text = "Player 2 Wins!";
//        winnerPanel.SetActive(true);
//        Winner = true;
//    }

//    private void PlayerDraw()
//    {
//        winnerText.text = "It's a Draw!";
//        winnerPanel.SetActive(true);
//        Winner = true;
//    }
//}
