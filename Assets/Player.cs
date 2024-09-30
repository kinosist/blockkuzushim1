using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;     // プレイヤーのスピード

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 右移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // 右矢印キーが押された場合
            // プレイヤーの位置を右に移動
            // transform.position.x プレイヤーのx座標が4未満の場合に移動
            if (transform.position.x < 4)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
        // 左移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // 左矢印キーが押された場合
            // プレイヤーの位置を左に移動
            // transform.position.x プレイヤーのx座標が-4超の場合に移動
            if (transform.position.x > -4)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
    }
}
