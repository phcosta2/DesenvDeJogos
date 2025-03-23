using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Pontuação do jogador
    public int pontuacao = 0;

    // Instância do GameManager (Singleton)
    public static GameManager instance;

    // UI para mostrar a pontuação
    public UnityEngine.UI.Text pontuacaoTexto;

    // Configurações de inicialização
    void Awake()
    {
        // Verifica se já existe uma instância do GameManager
        if (instance == null)
        {
            instance = this; // Define esta instância como a única
            DontDestroyOnLoad(gameObject); // Não destruir ao carregar nova cena
        }
        else
        {
            Destroy(gameObject); // Se já existe uma instância, destrua a nova
        }
    }

    // Método para adicionar pontos
    public void AdicionarPontuacao(int pontos)
    {
        pontuacao += pontos;
        AtualizarPontuacaoUI();
    }

    // Atualiza a UI de pontuação
    void AtualizarPontuacaoUI()
    {
        if (pontuacaoTexto != null)
        {
            pontuacaoTexto.text = "Pontuação: " + pontuacao;
        }
    }

    // Método para reiniciar o jogo (carregar a cena novamente)
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Método para finalizar o jogo (carregar a cena de fim de jogo)
    public void FinalizarJogo()
    {
        SceneManager.LoadScene("EndGame");
    }
}
