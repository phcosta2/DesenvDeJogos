using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameScripts
{
    public class Paralax : MonoBehaviour
    {
        private float lenght;
        public float parallaxEffect;
        public GameObject background1;  // O primeiro fundo
        public GameObject background2;  // O segundo fundo

        private float speed1;
        private float speed2;

        // Start is called before the first frame update
        void Start()
        {
            // Calcula o comprimento da tela para o movimento
            lenght = GetComponent<SpriteRenderer>().bounds.size.x;

            // Inicializa a velocidade dos fundos
            speed1 = parallaxEffect;
            speed2 = parallaxEffect;
        }

        // Update is called once per frame
        void Update()
        {
            // Movimento contínuo dos dois fundos
            background1.transform.position += Vector3.left * speed1 * Time.deltaTime;
            background2.transform.position += Vector3.left * speed2 * Time.deltaTime;

            // Verifica se o primeiro fundo saiu da tela
            if (background1.transform.position.x < -lenght)
            {
                ResetBackground(background1);
            }

            // Verifica se o segundo fundo saiu da tela
            if (background2.transform.position.x < -lenght)
            {
                ResetBackground(background2);
            }

            // Verifica se a pontuação atingiu um múltiplo de 500 e diminui o parallax
            if (Projetil.pontuacao >= 500)
            {
                // Diminuir a velocidade do parallax
                parallaxEffect -= 0.2f;
                speed1 = parallaxEffect;
                speed2 = parallaxEffect;
            }
        }

        // Reseta a posição do fundo para criar o efeito contínuo
        private void ResetBackground(GameObject background)
        {
            Vector3 newPos = new Vector3(lenght, background.transform.position.y, background.transform.position.z);
            background.transform.position = newPos;
        }
    }
}
