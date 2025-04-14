using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {
    void Start() {
        
    }

    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D collision) { // trigger eh quando o personagem pode passar por cima no objeto (se fosse uma bola nao teria trigger por exemplo)
    if (collision.gameObject.tag == "Player" && GameController.instance.isCoinsEmpty == true) {
    string currentScene = SceneManager.GetActiveScene().name;

    if (currentScene == "Fase1") {
        SceneManager.LoadScene("Fase3");
    } else if (currentScene == "Fase3") {
        SceneManager.LoadScene("WinGame");
    }
    }

}

}