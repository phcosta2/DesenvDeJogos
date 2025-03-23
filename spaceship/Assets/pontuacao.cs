using UnityEngine;
using UnityEngine.SceneManagement;  // Necessário para acessar o nome da cena atual

public class pontuacao : MonoBehaviour 
{
    public GUISkin layout;  // Fonte do placar

    void OnGUI () 
    {
        // Verifica a cena ativa antes de renderizar o placar
        string sceneName = SceneManager.GetActiveScene().name;

        // Só exibe a pontuação se não estiver na tela de "Start" ou "End"
        if (sceneName != "Start" && sceneName != "End")
        {
            GUI.skin = layout;

            // Exibe a pontuação no canto superior esquerdo
            GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 4000, 4000), "Pontuação: " + Projetil.pontuacao);
        }
    }
}
