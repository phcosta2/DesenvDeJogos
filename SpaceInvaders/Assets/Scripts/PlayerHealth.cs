using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int vidas = 3; // Número de vidas do jogador
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;
    
    public void TakeDamage() {

        vidas--; // Diminui uma vida

        if (vidas == 2) {
            GameObject vida3 = GameObject.Find("vida3");
            vida3.GetComponent<SpriteRenderer>().enabled = false;
        } else if (vidas == 1) {
            GameObject vida2 = GameObject.Find("vida2");
            vida2.GetComponent<SpriteRenderer>().enabled = false;
        } else if (vidas == 0) {
            GameObject vida1 = GameObject.Find("vida1");
            vida1.GetComponent<SpriteRenderer>().enabled = false;
        }



        // Verifica se o jogador perdeu todas as vidas
        if (vidas <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene("EndGame");
    }
}
