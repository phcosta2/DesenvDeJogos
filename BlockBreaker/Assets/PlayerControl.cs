using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    public KeyCode moveLeft = KeyCode.A;      // Move a raquete para cima
    public KeyCode MoveRight = KeyCode.D;    // Move a raquete para baixo
    public float speed = 10.0f;             // Define a velocidade da raquete
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update () {

    var vel = rb2d.velocity;                // Acessa a velocidade da raquete
    if (Input.GetKey(moveLeft)) {             // Velocidade da Raquete para ir para cima
        vel.x = -speed;
    }
    else if (Input.GetKey(MoveRight)) {      // Velocidade da Raquete para ir para cima
        vel.x = speed;                    
    }
    else {
        vel.x = 0;                          // Velociade para manter a raquete parada
    }
    rb2d.velocity = vel;                    // Atualizada a velocidade da raquete

    var pos = transform.position;           // Acessa a Posição da raquete
    if (pos.x > 5.9f) {
        pos.x = 5.9f;
    }
    else if (pos.x < -5.9f) {
        pos.x = -5.9f;
    }
    transform.position = pos;               // Atualiza a posição da raquete
   
}

}
