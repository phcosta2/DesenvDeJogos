using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float velocidade = 10f;
    public static int pontuacao = 0;
    public static int pontuacaomax = 0;
    void Update()
    {
        // Move o projétil para a direita
        transform.position += Vector3.right * velocidade * Time.deltaTime;

        // Destroi o projétil se ele sair da tela
        if (transform.position.x > 12f) 
        {
            Destroy(gameObject);
        }
    }
}
