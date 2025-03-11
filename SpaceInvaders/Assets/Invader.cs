using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float timer = 0.0f;
    private float waitTime = 1.0f;  // Tempo para o qual o invasor se move antes de mudar a direção no eixo X
    private float fowardtimer = 0.0f;
    private float fowardTime = 4.0f;  // Tempo após o qual o invasor vai subir no eixo Y
    private float speed = 1.0f;
    private float yMoveAmount = -0.2f;  // Quanto o invasor sobe a cada intervalo
    private bool shouldMoveUp = false;  // Controla quando o invasor deve subir

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);  // Inicializa o movimento no eixo X
    }

    // Update is called once per frame
    void Update()
    {
        // Controle do movimento no eixo X
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {
            ChangeState();
            timer = 0.0f;  // Resetando o timer para o movimento no eixo X
        }

        // Controle do movimento no eixo Y (subir de tempos em tempos)
        fowardtimer += Time.deltaTime;
        if (fowardtimer >= fowardTime)
        {
            shouldMoveUp = true;  // Permite que o invasor suba no eixo Y após o intervalo
            fowardtimer = 0.0f;   // Resetando o timer para o próximo intervalo
        }

        if (shouldMoveUp)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);  // Reseta a velocidade Y para que o movimento não continue subindo continuamente
            transform.position = new Vector3(transform.position.x, transform.position.y + yMoveAmount, transform.position.z);  // Subir 0.5 unidades no eixo Y
            shouldMoveUp = false;  // Após subir, não deixa continuar subindo até o próximo intervalo
        }
    }

    // Altera a direção do movimento no eixo X
    void ChangeState()
    {
        rb2d.velocity = new Vector2(-rb2d.velocity.x, rb2d.velocity.y);  // Inverte o movimento no eixo X
    }
}
