using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planete : MonoBehaviour {
    // VARIABLES
    public float vitesseRotation;
    public float vitesseTournerAutour;
    public Transform centre;

    // FONCTIONS
    void Update() {
        transform.Rotate(Vector3.up * Time.deltaTime * vitesseRotation); // Fait tourner les satellites autour des planètes
        transform.RotateAround(centre.position, Vector3.up, Time.deltaTime * vitesseTournerAutour); // Fait tourner les planètes autour du Soleil
    }
}
