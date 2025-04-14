using UnityEngine;
using TMPro;
using System.Collections; // ESSENCIAL para IEnumerator

public class Dialogue2 : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines = { "Ande no a e d", "Agora você aprendeu!" }; // Exemplo com 2 linhas

    public float textSpeed = 0.05f;
    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialog();
    }

    void Update()
    {
        if (Input.anyKeyDown) // Detecta qualquer tecla pressionada
        {
            // Se o texto estiver completo, vai para a próxima linha ou fecha o diálogo
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            StartCoroutine(FecharDialogo());
        }
    }

    IEnumerator FecharDialogo()
    {
        yield return new WaitForSeconds(0.5f); // Espera um pouco antes de fechar o diálogo
        gameObject.SetActive(false); // Fecha o painel de diálogo
    }
}
