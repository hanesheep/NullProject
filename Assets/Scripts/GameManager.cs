using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    playing,
    gameover,
    gameclear,
}

public class GameManager : MonoBehaviour
{
    public static GameState gameState;


    void Awake()
    {
        //ゲームの初期状態をplaying
        gameState = GameState.playing;
    }

    //private void Update()
    //{

    //    if (gameState == GameState.gameclear)
    //    {

    //        //ボスを殲滅したらエンディングへ
    //        StartCoroutine(Title());
    //    }
    //}

}