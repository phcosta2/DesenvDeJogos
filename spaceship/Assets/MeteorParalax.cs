using UnityEngine;
using GameScripts;  // Para garantir que o script Projetil esteja acessível
using UnityEngine.SceneManagement;

public class MeteoroParallax : MonoBehaviour
{
    public float velocidadeMin = 2f; // Velocidade mínima do meteoro
    public float velocidadeMax = 3.5f; // Velocidade máxima do meteoro
    public float alturaMin = -4f; // Altura mínima de spawn
    public float alturaMax = 4f; // Altura máxima de spawn
    public float spawnX = 10f; // Posição inicial do meteoro (fora da tela)
    public float limiteX = -12f; // Posição onde o meteoro desaparece

    private float velocidade;
    private float velocidadeOriginal;
    private float tempoReduzido = 0f; // Tempo que a velocidade será reduzida
    private bool velocidadeReduzida = false;

    void Start()
    {
        Projetil.pontuacaomax = 0;
        Projetil.pontuacao = 0;
        ResetMeteoro();
        velocidadeOriginal = velocidade; // Armazena a velocidade original
    }

    void Update()
    {
        // Verifica a pontuação e diminui a velocidade se necessário
        if (Projetil.pontuacao >= 500 && !velocidadeReduzida)
        {
            Projetil.pontuacao = 0;
            velocidadeReduzida = true;
            velocidade = velocidadeOriginal - 1.9f; // Diminui a velocidade do meteoro
            tempoReduzido = 5f; // reduzir o tempo por 5 segundos
        }

        // Reduz o tempo do efeito de velocidade reduzida
        if (velocidadeReduzida)
        {
            tempoReduzido -= Time.deltaTime;
            if (tempoReduzido <= 0f)
            {
                velocidade = velocidadeOriginal; // Restaura a velocidade original
                velocidadeReduzida = false; // Desativa o efeito de velocidade reduzida
            }
        }

        // Move o meteoro para a esquerda
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        // Verifica se o meteoro saiu completamente da tela
        if (transform.position.x < limiteX)
        {
            ResetMeteoro();
        }
    }

    void ResetMeteoro()
    {
        // Define uma nova posição inicial completamente à direita da tela
        transform.position = new Vector3(spawnX, Random.Range(alturaMin, alturaMax), transform.position.z);

        // Define uma velocidade aleatória para dar variação
        velocidade = Random.Range(velocidadeMin, velocidadeMax);
        velocidadeOriginal = velocidade; // Armazena a nova velocidade original ao resetar
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Laser")) // Se colidir com o Laser
        {
            // Adiciona 100 pontos sempre que o meteoro for destruído
            Projetil.pontuacao += 100; 
            Projetil.pontuacaomax += 100; 
            // Novo meteoro
            ResetMeteoro();
        }

        if (other.CompareTag("Player")) // 
        {
            SceneManager.LoadScene("End"); // Derrota

        }
    }
}
