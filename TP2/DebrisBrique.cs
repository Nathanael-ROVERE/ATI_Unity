using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class DebrisBrique : MonoBehaviour {

    // Variables
    public float force = 10f;

    // On place la génération aléatoire dans un Upadte() plutôt qu'un Start()
    // pour que chaque Cube ait des débris différents
    void Update() {
        // Génération des débris aléatoirement
        Vector3 motion;
        motion.x = Random.Range(-1f, 1f);
        motion.y = Random.Range(-1f, 1f);
        motion.z = Random.Range(-1f, 1f);
        GetComponent<Rigidbody>().AddForce(motion*force);
    }

    // destruction des débris quand ils quittent l'écran
    void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
