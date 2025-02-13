using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotScript : MonoBehaviour
{
    private Rigidbody2D rb2d; 
    private Transform ball;    // Referência à bola
    private float speed = 10f; // Velocidade de movimento do bot

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); 
        ball = GameObject.FindWithTag("Ball").transform;  // ele encontra a bola na cena
    }

    void Update()
    {
        MoveToBall();
    }

    void MoveToBall()
    {
        // Calcula a posição da bola em X
        float targetX = ball.position.x;
        
        // Movimenta o bot na direção X da bola
        if (transform.position.x < targetX)
        {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);  // Move para a direita (no eixo X positivo)
        }
        else if (transform.position.x > targetX)
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);  // Move para a esquerda (no eixo X negativo)
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);  // Para de mover quando estiver alinhado no eixo X
        }
    }
}
