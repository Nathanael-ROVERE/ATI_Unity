using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MeatBoy : MonoBehaviour {
    // VARIABLES
    public float speed, jumpSpeed, gravity;
    public int jumpsMax;
    private int jumpsCount = 1;
    private Vector3 mouvement;
    private CharacterController controller;
    public GameObject gouttePrefab;
    public float delayGoutte;
    private float cptGoutte;
    private Vector3 defaultPosition;

    // FONCTIONS
    void Awake() {
        controller = GetComponent<CharacterController>();
    }

    void Start() {
        defaultPosition = transform.position;
    }

    public void Die() {
        transform.position = defaultPosition;
        print("YOU DIED");
    }

    void Update() {
        // Mouvement latéral
        mouvement.x = Input.GetAxis("Horizontal") * speed;    
        controller.Move(mouvement * Time.deltaTime); //permet que le charactercontroller se déplace horizontalement avec la physique propre à ce component

        // Gravité
        mouvement.y += gravity * Time.deltaTime;
        if (controller.isGrounded) {
            mouvement.y = 0;
            jumpsCount = 0;
        }

        // Saut
        if (Input.GetButtonDown("Jump")) {
            if (jumpsCount<jumpsMax) {
                mouvement.y = jumpSpeed;
                jumpsCount++;
            }
        }

        // Gouttes
        if (mouvement.x != 0f) {
            cptGoutte -= Time.deltaTime;
        }
        if (cptGoutte < 0) {
            GameObject goutte = Instantiate(gouttePrefab, transform.position, Quaternion.identity);
            goutte.GetComponent<Goutte>().velocity = new Vector3(-mouvement.x, speed, 0f);
            cptGoutte = delayGoutte;
        }

        // Sortie
        if (Input.GetKey("escape")) { Application.Quit(); }
    }
}
