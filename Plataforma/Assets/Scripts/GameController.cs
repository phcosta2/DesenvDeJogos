using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public int totalScore; // nossa pontuacao total
    public static GameController instance; // assim eu posso chamar qualquer variavel nao privada em outras classes
    public TMP_Text scoreText; // nossa pontuacao
    public GameObject gameOver; // instaciar o game over criado na unity
    public List<GameObject> coins; // minha lista de moedas na fase
    public bool isCoinsEmpty = false; // se for true a lista esta vazia

    void Start() {
        instance = this; // assim eu posso chamar qualquer variavel nao privada em outras classes

        GameObject[] allCoins = GameObject.FindGameObjectsWithTag("Coin"); // achar todas as moedas da cena
        foreach (GameObject coin in allCoins) { // adicionar na lista de moedas todas as moedas da cena
            coins.Add(coin);
        }
    }

    public void AtualizaScoreText() {
        scoreText.text = totalScore.ToString(); // pega o atributo text la do unity e altera (so aceita string)
    }

    public void GameOver() {
        gameOver.SetActive(true); // passa a deixar ativo a imagem de game over que antes estava invisivel
    }

    public void RestartGame() { // se der gameover volta para o comeco da fase
        SceneManager.LoadScene("Fase1");
    }

    public void RestartFase2() {
        SceneManager.LoadScene("Fase2");
    }

    public void CollectCoins(GameObject coin) {
        coins.Remove(coin); // remove a moeda da lista de moedas
        Debug.Log(coins.Count);
    }

    public void CoinsEmpty() { // verifica se a lista esta vazia
        if (coins.Count == 0) {
            isCoinsEmpty = true;
        }
    }

}
