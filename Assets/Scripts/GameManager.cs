using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Permite controlarmos as cenas

public class GameManager : MonoBehaviour {
    
    void Start() {
    }

    void Update() {
        //Checando se o jogador apertou enter
        if (Input.GetKeyDown(KeyCode.Return)) {
            InitGame();
        }
    }

    public void InitGame() {
        SceneManager.LoadScene("Game");
    }

}
