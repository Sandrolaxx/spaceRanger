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
        Destroy(gameObject, 3f);//Destruindo após 3 segundos caso não atinja ninguém
    }

     //Evento de trigger com o inimigo
    private void OnTriggerEnter2D(Collider2D collision) {
        if (!collision.CompareTag("End")) {
            //Chamando método de morte do inimigo
            collision.GetComponent<Enemy>().Die();

            Destroy(collision.gameObject);//Destruindo o elemento que colidiu
            Destroy(gameObject);//Destruindo o elemento do tiro
        }
    }

}
