using UnityEngine;

public class CoinCollect : MonoBehaviour {

    private SpriteRenderer sr; // é onde desativa o objeto da cena, ele ainda ta la, mas nao visivel
    private BoxCollider2D box; // colisao
    public GameObject collected; // instancia nossa animacao de coletar moeda
    public int score = 5; // vai ser nossa pontuacao de moedas pegas

    void Start() {
        sr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();

    }

    void OnTriggerEnter2D(Collider2D collider) { // trigger eh quando o personagem pode passar por cima no objeto (se fosse uma bola nao teria trigger por exemplo)
        if (collider.gameObject.tag == "Player") {
            sr.enabled = false; // deixa a moeda nao visivel na cena
            box.enabled = false; // desativa a colisao
            collected.SetActive(true); // deixa visivel a animacao de coletar a moeda

            GameController.instance.totalScore += score; // aumenta o score la na tela de jogo
            GameController.instance.AtualizaScoreText(); // chama a funcao de atualizar a score

            GameController.instance.CollectCoins(gameObject); // chama minha funcao para atualizar a lista de moedas
            GameController.instance.CoinsEmpty(); // chama a funcao para saber se tem 0 moedas na lista

            Destroy(gameObject, 0.1f); // destruir o próprio objeto -> moeda depois de 1sec

        }

    }

}
