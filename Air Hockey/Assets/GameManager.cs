using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public static int PlayerScore1 = 0; // Pontuação do player 1
    public static int PlayerScore2 = 0; // Pontuação do player 2

    public GUISkin layout;              // Fonte do placar
    GameObject theBall;                 // Referência ao objeto bola
    // Start is called before the first frame update
void Start () {
    theBall = GameObject.FindGameObjectWithTag("Ball"); // Busca a referência da bola
}

public static void Score (string wallID) {
    if (wallID == "Gol1")
    {
        PlayerScore1++;
    } 
    if(wallID == "Gol2")
    {
        PlayerScore2++;
    }
}


void OnGUI () {
    GUI.skin = layout;
    GUI.Label(new Rect(Screen.width / 2 - 150 - 90, 200, 300, 300), "Azul");
    GUI.Label(new Rect(Screen.width / 2 - 150 - 90, 250, 300, 300), "" + PlayerScore1);
    GUI.Label(new Rect(Screen.width / 2 + 150 + 90, 200, 300, 300), "Verde(Eu)");
    GUI.Label(new Rect(Screen.width / 2 + 150 + 90, 250, 300, 300), "" + PlayerScore2);
  
    if (GUI.Button(new Rect(Screen.width / 2 - 400, 35, 120, 53), "RESTART"))
    {
        PlayerScore1 = 0;
        PlayerScore2 = 0;
        theBall.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
    }
    if (PlayerScore1 == 10)
    {
        GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
        theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
    } else if (PlayerScore2 == 10)
    {
        GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
        theBall.SendMessage("ResetBall", null, SendMessageOptions.RequireReceiver);
    }
}

}
