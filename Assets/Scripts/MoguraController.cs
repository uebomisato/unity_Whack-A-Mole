using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraController : MonoBehaviour,IEnemy
{
    // 速度
    //[SerializeField]
    //public Vector2 SPEED = new Vector2(0.05f, 0.05f);

    //Vector2 Position;

    public float nowPosi = 1.0f;

    public float _HitPoint = 100.0f;

    //public float MovingDistance = -3;


    private float StartPos;

    bool _moveFlag = true;


    //-------

    // 速度
    //public Vector2 SPEED = new Vector2(0.5f, 0.5f);

    private float speed = 0.05f;


    public void AddDamage(float damage)
    {
        _HitPoint -= damage;
        Debug.Log("敵に" + damage + "のダメージ！");
        Debug.Log("残りHP: " + _HitPoint);

        if (_HitPoint <= 0)
        {
            Debug.Log("Enemyを倒した");
        }

    }

    public void MoveSpeed(float _startPos)
    {

        //Position.y = speed.y;
        //transform.position = Position;


        // コメントアウト
        //transform.position = new Vector2(transform.position.x, nowPosi + Mathf.PingPong(Time.time / 3, 0.6f));


        transform.position = new Vector2(transform.position.x, _startPos + Mathf.PingPong(Time.time, transform.position.z));

        //transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z);
    }

    // Start is called before the first frame update
    void Start()
    {
        // 現在位置をPositionに代入
        //Position = transform.position;

        //nowPosi = this.transform.position.y;

        StartPos = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //MoveSpeed(MovingDistance);
        //MoveSpeed(StartPos);

        Move();
    }

    // 移動関数
    void Move()
    {
        // 現在位置をPositionに代入
        Vector2 Position = transform.position;

        if (_moveFlag == true) {
            Position.y += speed;

            if (Position.y == 0.0) {
                _moveFlag = false;
            }
        } else if (_moveFlag == false) {
            Position.y -= speed;

            if (Position.y == -5.0f)
            {
                _moveFlag = true;
            }
        }

        //Position.y += SPEED.y;
        // 現在の位置に加算減算を行ったPositionを代入する
        transform.position = Position;

        Debug.Log("NowPosition: " + transform.position + " ,flug: " + _moveFlag);
    }

}
