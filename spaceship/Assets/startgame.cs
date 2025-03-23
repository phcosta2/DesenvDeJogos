using UnityEngine;
using UnityEngine.SceneManagement;  // Necessário para carregar cenas

public class startgame : MonoBehaviour
{
    public GUISkin layout;  // Fonte do placar

    void OnGUI()
    {
        // Aplica o estilo de GUI
        GUI.skin = layout;

        // Exibe "SPACESHIP" no meio da tela
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 150, 100), "SPACESHIP");

        // Cria o botão que vai para a cena "Game"
        if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 50, 150, 50), "Start Game"))
        {
            // Carrega a cena chamada "Game" quando o botão for clicado
            SceneManager.LoadScene("Game");
        }
    }
}
