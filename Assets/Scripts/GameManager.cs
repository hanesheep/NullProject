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


    void Start()
    {
        gameState = GameState.playing;


        //シーン情報の取得
        Scene currentScene = SceneManager.GetActiveScene();
        //シーン名の取得
        string sceneName = currentScene.name;

        switch (sceneName)
        {
            case "Title":
                //サウンドをつけるときに非表示解除
                //SoundManager.instance.PlayBgm(BGMType.Title);
                break;
            case "BaseStage":
                //SoundManager.instance.PlayBgm(BGMType.InGame);
                break;
        }
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