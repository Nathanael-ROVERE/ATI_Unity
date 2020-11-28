using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scie : MonoBehaviour {
    // VARIABLES
    public float speed;
    public GameObject gouttePrefab;
    public Texture tache;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider) {
        if(collider.tag == "Player") {
            Instantiate(gouttePrefab, transform.position, Quaternion.identity);
            GetComponent<Renderer>().material.mainTexture = tache;
            collider.GetComponent<MeatBoy>().Die();
        }
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
