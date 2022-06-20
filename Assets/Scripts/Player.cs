using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public AudioClip shootSfx;
    public float shipVelocity = 3f;
    public float xMin = -2.5f;
    public float xMax = 2.5f;

    // Pegando o objeto do tiro
    public GameObject shoot;
    public GameObject levelTitle;

    void Start() {
        GameObject levelTitleInstantiated = Instantiate(levelTitle, new Vector3(0.1f, 3f), transform.rotation);

        Destroy(levelTitleInstantiated, 3);
    }

    void Update() {

        Vector3 movement = transform.position;

        movement.x += Input.GetAxis("Horizontal") * shipVelocity * Time.deltaTime;

        //Garantindo que o player não saia da tela
        movement.x = Mathf.Clamp(movement.x, xMin, xMax);

        if (Input.GetButtonDown("Fire1")) {
            Fire();
        }

        transform.position = movement;

    }

    private void Fire() {
        Instantiate(shoot, transform.position, transform.rotation);//Criando objeto do tiro
        AudioSource.PlayClipAtPoint(shootSfx, transform.position);
    }

}
