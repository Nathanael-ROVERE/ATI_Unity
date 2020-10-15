using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // VARIABLES
    public float vitesseDeplacement;
    public float vitesseRotation;
    private float acceleration = 0;
    public float accelerationSpeed;
    private Vector3 mouvement = Vector3.zero;

    // FONCTIONS
    void Update() {
        if ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.DownArrow))) {
            acceleration++;
            transform.Translate(Vector3.forward * Time.deltaTime * accelerationSpeed);
            if (acceleration>vitesseDeplacement) {acceleration=vitesseDeplacement;}
        }
        else if ((!Input.GetKey(KeyCode.UpArrow)) && (!Input.GetKey(KeyCode.DownArrow))) {
            acceleration--;
            transform.Translate(Vector3.forward * Time.deltaTime * accelerationSpeed);
            if (acceleration<0) {acceleration=0;}
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            //transform.Translate(Vector3.forward * Time.deltaTime * acceleration);
            mouvement = Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            //transform.Translate(-Vector3.forward * Time.deltaTime * acceleration);
            mouvement = -1f * Vector3.forward;
        }
        transform.Translate(mouvement * Time.deltaTime * acceleration);

        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.up * Time.deltaTime * vitesseRotation);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(-Vector3.up * Time.deltaTime * vitesseRotation);
        }
        if (Input.GetKey("escape")) {Application.Quit();}
    }
}
