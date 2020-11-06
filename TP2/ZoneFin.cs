using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneFin : MonoBehaviour {

    // Fonctions
    void OnTriggerEnter(Collider other) {

        // Quand la balle n'est pas rattrapée, on recharge la scene
        if (other.gameObject.tag == "Balle") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
