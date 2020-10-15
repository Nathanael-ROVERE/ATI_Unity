using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroides : MonoBehaviour {
    // VARIABLES
    public Vector3 axe = Vector3.zero;

    //FONCTIONS
    void Start() {
        axe.x = Random.Range(-90,90);
        axe.y = Random.Range(-90,90);
        axe.z = Random.Range(-90,90);
    }

    void Update() {
        transform.Rotate(axe * Time.deltaTime);
    }
}
