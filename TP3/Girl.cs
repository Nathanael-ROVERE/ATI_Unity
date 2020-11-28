using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    // VARIABLES
    public float gravity;
    public int jump;
    private Vector3 vertical;
    private CharacterController controller;

    // FONCTIONS
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Gravité
        controller.Move(vertical * Time.deltaTime);
        vertical.y += gravity * Time.deltaTime;
        if (controller.isGrounded)
        {
            vertical.y = jump;
        }
    }
}
