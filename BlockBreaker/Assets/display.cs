using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class display : MonoBehaviour
{

void OnGUI () {

    GUIStyle style = new GUIStyle();
    style.fontSize = 50;  // Define o tamanho da fonte
    style.alignment = TextAnchor.MiddleCenter;  // Alinha o texto no centro

    GUIStyle style2 = new GUIStyle();
    style2.fontSize = 20;  // Define o tamanho da fonte
    style2.alignment = TextAnchor.MiddleCenter;  // Alinha o texto no centro


    if (GUI.Button(new Rect(Screen.width / 2 - 60, 350, 120, 53), "START"))
    {
        SceneManager.LoadScene("Fase1");
    }

    GUI.Label(new Rect(Screen.width / 2 - 100, 390, 200, 100), "Arkanoid é uma emocionante recriação do clássico jogo de quebra-blocos" , style2);

    GUI.Label(new Rect(Screen.width / 2 - 100, 410, 200, 100), "onde você controla uma bola que deve destruir blocos coloridos", style2);

}
    // Update is called once per frame
}






