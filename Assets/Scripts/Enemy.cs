using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

    public Rigidbody2D enemyRb;//Definindo Rigidbody
    public GameObject enemyExplosion;
    public AudioClip explosionSfx;
    public float enemyVelocity = 2f;

    void Start() {
        //Ao iniciar demos uma velocidade ao Rigidbody, Vector2.down é igual a new Vector2(0, -1), 
        //onde o -1 que é eixo y é multiplicado pela velocidade, assim movimentando o elemento nesse eixo
        enemyRb.velocity = Vector2.down * enemyVelocity;
    }

    void Update() {
        Destroy(gameObject, 10f);//Destruindo caso não destruído pelo player
    }

    //Ao morrer chamar a animação de explosão
    public void Die() {
        GameObject explosion = Instantiate(enemyExplosion, transform.position, transform.rotation);
        
        Destroy(explosion, 0.4f);

        AudioSource.PlayClipAtPoint(explosionSfx, transform.position);

        if (GameManager.GetDeads() >= 5) {
            GameManager.ResetDead();
            SceneManager.LoadScene("GameLv2");
        } else {
            GameManager.SumDead();
        }
    }

    //Checando se tocou na trigger do EndGame
    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag("End")) {
            SceneManager.LoadScene("Menu");//Podemos passar tanto o nome quanto o index da cena
        }

    }

}
