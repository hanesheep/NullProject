using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject mainImage;   //アナウンスをする画像
    
    public Sprite gameClearSprite; //ゲームクリアの絵
    public Sprite gameOverSprite;  //ゲームオーバーの絵
    public GameObject retryButton; //リトライボタン
    public GameObject buttonPanel;


    void Start()
    {
        buttonPanel.SetActive(false);
        //時間差でメソッドを発動
        Invoke("InactiveImage", 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameState == GameState.playing)
        {
            //2秒後に削除 
            Destroy(gameObject, 2.0f); 


        }

        else if (GameManager.gameState == GameState.gameover)
        {
            buttonPanel.SetActive(true); //ボタンパネルの復活
            mainImage.SetActive(true);　 //メイン画像の復活
            //メイン画像オブジェクトのImageコンポーネントが所持している変数spriteにステージクリアの絵を代入
            mainImage.GetComponent<Image>().sprite = gameOverSprite;
            //リトライボタンオブジェクトのButtonコンポーネントが所持している変数interactibleを無効（ボタン機能を無効）
            retryButton.GetComponent<Button>().interactable = false;

        }
        else if (GameManager.gameState == GameState.gameclear)
        {
            buttonPanel.SetActive(true); //ボタンパネルの復活
            mainImage.SetActive(true);　 //メイン画像の復活
            //メイン画像オブジェクトのImageコンポーネントが所持している変数spriteにステージクリアの絵を代入
            mainImage.GetComponent<Image>().sprite = gameClearSprite;
            //リトライボタンオブジェクトのButtonコンポーネントが所持している変数interactibleを無効（ボタン機能を無効）
            //retryButton.GetComponent<Button>().interactable = false;

        }

    }

    //メイン画像を非表示にするためだけのメソッド
    void InactiveImage()
    {
        mainImage.SetActive(false);
    }

}