using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraController : MonoBehaviour,IEnemy
{
    // 速度
    //[SerializeField]
    //public Vector2 SPEED = new Vector2(0.05f, 0.05f);

    Vector2 Position;

    public float nowPosi;

    public float _HitPoint = 100.0f;

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

    public void MoveSpeed(float nowPosi)
    {

        //Position.y = speed.y;
        //transform.position = Position;


        transform.position = new Vector2(transform.position.x, nowPosi + Mathf.PingPong(Time.time / 3, 0.6f));
    }

    // Start is called before the first frame update
    void Start()
    {
        // 現在位置をPositionに代入
        //Position = transform.position;

        nowPosi = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        MoveSpeed(nowPosi);
    }

    
}
