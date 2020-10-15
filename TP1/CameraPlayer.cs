using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour {
    // VARIABLES 
    public Transform joueur;
    public float vitesse;

    // FONCTIONS
    void Update() {
        Vector3 ciblePos = joueur.position;
        ciblePos.y = transform.position.y;
        transform.position = Vector3.Lerp(transform.position, ciblePos, Time.deltaTime * vitesse);
    }
}
