using UnityEngine;
using UnityEngine.SceneManagement;  // Necessário para carregar cenas

public class DisplayEnd : MonoBehaviour
{
    public GUISkin layout;  // Fonte do placar

    void OnGUI()
    {
        // Aplica o estilo de GUI
        GUI.skin = layout;

        // Exibe "GAME OVER" no meio da tela
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 50, 300, 100), "GAME OVER");

        // Exibe a pontuação final (caso você tenha uma variável de pontuação global, use-a aqui)
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 10, 300, 100), "Pontuação: " + Projetil.pontuacao);

        // Cria o botão que vai para a tela inicial
        if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 60, 150, 50), "Voltar ao Início"))
        {
            // Carrega a cena chamada "Start" quando o botão for clicado
            SceneManager.LoadScene("Start");
        }

        // Cria o botão que reinicia o jogo (vai para a cena do jogo novamente)
        if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 120, 150, 50), "Reiniciar Jogo"))
        {
            // Carrega a cena chamada "Game" quando o botão for clicado
            SceneManager.LoadScene("Game");
        }
    }
}
