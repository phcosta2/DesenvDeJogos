using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    void Start()
    {
        // Obtém o componente Button e adiciona um listener para detectar cliques
        GetComponent<Button>().onClick.AddListener(AoClicar);
    }

    void AoClicar()
    {
        Debug.Log("Jogo Iniciando!");
        SceneManager.LoadScene("Fase1");
    }
}
