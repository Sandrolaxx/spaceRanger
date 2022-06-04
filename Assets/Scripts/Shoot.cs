using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public Rigidbody2D shootRb;
    public float velocity = 8f;
    
    void Start() {
        shootRb.velocity = Vector2.up * velocity;
    }

    void Update() {
        
    }

     //Evento de trigger com o inimigo
    private void OnTriggerEnter2D(Collider2D collision) {
        Destroy(collision.gameObject);//Destruindo o elemento que colidiu
        Destroy(gameObject);//Destruindo o elemento do tiro
    }
}
