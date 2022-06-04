using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    //Definindo Rigidbody
    public Rigidbody2D enemyRb;
    public float enemyVelocity = 2f;

    void Start() {
        //Ao iniciar demos uma velocidade ao Rigidbody, Vector2.down é igual a new Vector2(0, -1), 
        //onde o -1 que é eixo y é multiplicado pela velocidade, assim movimentando o elemento nesse eixo
        enemyRb.velocity = Vector2.down * enemyVelocity;
    }

    void Update() {
        
    }
}
