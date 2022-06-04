using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float shipVelocity = 3f;

    // Pegando o objeto do tiro
    public GameObject shoot;

    void Start() {
    }

    void Update() {

        Vector3 movement = transform.position;

        movement.x += Input.GetAxis("Horizontal") * shipVelocity * Time.deltaTime;

        if (Input.GetButtonDown("Fire1")) {
            Instantiate(shoot, transform.position, transform.rotation);//Criando objeto do tiro
        }

        transform.position = movement;

    }

}
