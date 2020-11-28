using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Goutte : MonoBehaviour {
    // VARIABLES
    public Vector3 velocity;
    public int force;

    // FONCTIONS
    void Start() {
        GetComponent<Rigidbody>().AddForce(velocity*force);
    }

    void OnColliderEnter() {
        Destroy(GetComponent<Rigidbody>());
        Destroy(this);
    }
}
