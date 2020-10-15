using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaisseau : MonoBehaviour {
    // VARIABLES
    public Transform planete1;
    public Transform planete2;
    public float vitesse;
    public float distanceMin = 2f;
    private bool surPlanete1 = false;
    private bool surPlanete2 = true;
    private float distance;

    void Update() {
        transform.position = Vector3.MoveTowards(transform.position, planete1.position, Time.deltaTime * vitesse);
        transform.LookAt(planete1.position);

        if (surPlanete1) {
            transform.position = Vector3.MoveTowards(transform.position, planete2.position, Time.deltaTime * vitesse);
            transform.LookAt(planete2.position);
            distance = Vector3.Distance(transform.position, planete2.position);
            if (distance<distanceMin) {
                surPlanete1 = false;
                surPlanete2 = true;
            }
        }
        
        if (surPlanete2) {
            transform.position = Vector3.MoveTowards(transform.position, planete1.position, Time.deltaTime * vitesse);
            transform.LookAt(planete1.position);
            distance = Vector3.Distance(transform.position, planete1.position);
            if (distance<distanceMin) {
                surPlanete1 = true;
                surPlanete2 = false;
            }
        }
    }
}
