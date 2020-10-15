using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // VARIABLES
    public float vitesseDeplacement;
    public float vitesseRotation;

    // FONCTIONS
    void Start() {
        vitesseDeplacement = 30;
        vitesseRotation = 50;
    }

    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.forward * Time.deltaTime * vitesseDeplacement);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(-Vector3.forward * Time.deltaTime * vitesseDeplacement);
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.up * Time.deltaTime * vitesseRotation);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(-Vector3.up * Time.deltaTime * vitesseRotation);
        }
    }
}
