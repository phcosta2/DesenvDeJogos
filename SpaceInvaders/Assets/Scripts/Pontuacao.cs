using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour {
    public GUISkin layout;              // Fonte do placar

    void OnGUI () {
    GUI.skin = layout;
    GUI.Label(new Rect(Screen.width / 2 - 220 - 12, 20, 3500, 3500), "Pontuação:" + Projetil.pontuacao);
    }
    
    
}
