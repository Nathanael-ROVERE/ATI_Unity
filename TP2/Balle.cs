using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Balle : MonoBehaviour {

    // Variables
    public Vector3 deplacement;
    public int nbrBriques;
    public GameObject prefabDebris;
    public float speed;

    // Fonctions
    void FixedUpdate(){
        transform.Translate(deplacement * Time.deltaTime * speed); // pour que la balle se déplace
        GetComponent<Rigidbody>().velocity = deplacement;
    }

    void OnCollisionEnter(Collision collision) {

        deplacement = Vector3.Reflect(deplacement, collision.contacts[0].normal); // pour la balle rebondisse avec le bon angle

        if(collision.gameObject.tag == "Brique") {
            Destroy(collision.gameObject); // Lors d'une collision, avec une brique, celle-ci est détruite

            // nombre aléatoire de debris lors d'une collision
            int tmp = Random.Range(1, 4);
            for(int i=0; i<tmp; i++) {
                Instantiate(prefabDebris, collision.transform.position, Quaternion.identity);
            }
            
            nbrBriques--;
            speed += 0.02f; // on fait accélérer la balle à chaque collision avec une brique

            // fin de partie
            if (nbrBriques <= 0) {
                SceneManager.LoadScene("Victory"); // Victoire s'il n'y a plus de briques
            }
        }
    }
}
