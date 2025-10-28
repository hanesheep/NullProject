using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rbody;
    //public LayerMask groundLayer;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (GameManager.gameState != GameState.playing)
        {
            return; //その1フレを強制終了
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        //ぶつかった相手が"Goal"タグを持っていたら
        if (collision.gameObject.CompareTag("Goal"))
        {
            GameManager.gameState = GameState.gameclear;
            Debug.Log("くりあー");
            Goal();
        }

        //ぶつかった相手が"Dead"タグを持っていたら
        if (collision.gameObject.CompareTag("Dead"))
        {
            GameManager.gameState = GameState.gameover;
            Debug.Log("敗北者");
            GameOver();
        }
    }

    public void Goal()
    {
        GameStop();
    }

    public void GameOver()
    {
        GameStop();

        Destroy(gameObject, 3.0f);
    }

    void GameStop()
    {
        //速度を0にリセット
        rbody.angularVelocity = Vector3.zero;
    }
}
