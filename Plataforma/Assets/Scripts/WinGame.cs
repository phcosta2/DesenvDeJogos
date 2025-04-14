using UnityEngine;using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

    public GameObject win; // instaciar o win criado na unity

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter2D(Collision2D collision) { // trigger eh quando o personagem pode passar por cima no objeto (se fosse uma bola nao teria trigger por exemplo)
        win.SetActive(true); // passa a deixar ativo a imagem de vitoria que antes estava invisivel
    }

}
