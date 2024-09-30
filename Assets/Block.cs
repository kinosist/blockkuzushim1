using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnterはコライダーに他のオブジェクトが当たった時に呼び出される
    // 引数には当たった他のオブジェクトが入る
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);    // ブロックを削除
    }
}
