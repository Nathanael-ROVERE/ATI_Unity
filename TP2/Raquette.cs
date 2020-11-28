using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Raquette : MonoBehaviour {

    // Variables 
    public float speed; // vitesse de la raquette
    public float clampX;

    // Fonctions
    void Update() {
        // déplacement horizontal
        float h = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * h * speed);

        // blocage de la raquette des deux côtés
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -clampX, clampX);
        transform.position = pos;

        if (Input.GetKey("escape")) { Application.Quit(); }
    }
}
