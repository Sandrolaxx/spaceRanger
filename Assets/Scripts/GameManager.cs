using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Permite controlarmos as cenas

public class GameManager : MonoBehaviour {

    public static int deadEnemys = 0;

    void Update() {
        //Checando se o jogador apertou ENTER
        if (Input.GetKeyDown(KeyCode.Return)) {
            InitGame();
        }
        //Checando se o jogador apertou ESC
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("Quitou!!");
            Application.Quit();
        }
    }

    public void InitGame() {
        SceneManager.LoadScene("Game");
    }

    public static void SumDead() {
        deadEnemys += 1;
    }

    public static void ResetDead() {
        deadEnemys = 0;
    }

    public static int GetDeads() {
        return deadEnemys;
    }

}
