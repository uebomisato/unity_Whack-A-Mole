using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// TODO: タップした先にハンマー表示
// TODO: タップしたら、叩くアニメーション再生

public class HammerManager : MonoBehaviour
{
    Animator animator; //animatorを宣言
    public GameObject hammerObject; //追記


    // 移動スピード
    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //宣言したanimatorに、Animatorコンポーネントを取得する
    }

    // Update is called once per frame
    void Update()
    {
        //var mousePosition = Input.mousePosition;　//追記
        ////mousePosition.z = 10; //追記
        //var pos = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));//追記
        //hammerObject.transform.position = pos;//追記。

        //if (Input.GetMouseButtonDown(0))　//マウスクリック情報を取得する
        //{
        //    Debug.Log("入力されてる");　//マウスクリックが入っているかどうかの、確認ログ
        //    animator.SetTrigger("Move0");　//SetTriggerでMove0を発動させる
        //}


        Vector2 direction = new Vector2(0, 0);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float x = touch.deltaPosition.x;
            float y = touch.deltaPosition.y;

            //　移動する向きを求める
            direction = new Vector2(x, y).normalized;


            if (touch.phase == TouchPhase.Ended)
            {
                Debug.Log("離した瞬間");
                animator.SetTrigger("Move0");　//SetTriggerでMove0を発動させる
            }

        }

        Move(direction, speed);

    }

    void Move(Vector2 direction, float speed)
    {
        // プレイヤーの座標の取得と移動量
        Vector2 pos = transform.position;
        pos += direction * speed * Time.deltaTime;

        // プレイヤーの新規位置とする
        transform.position = pos;
    }
}
