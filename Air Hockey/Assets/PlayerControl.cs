using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Limitar a posição com Mathf.Clamp
        float clampedX = Mathf.Clamp(mousePos.x, -4.5f, 4.5f);
        float clampedY = Mathf.Clamp(mousePos.y, 0f, 10f);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}
