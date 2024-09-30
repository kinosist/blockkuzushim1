using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;     // ボールのスピード
    private Rigidbody rb;          // Rigidbodyコンポーネント

    // Start is called before the first frame update
    void Start()
    {
        // ボールのRigidbodyコンポーネントを取得
        rb = GetComponent<Rigidbody>();
        // ゲーム開始時にボールを右前に動かす
        // AddForce(ベクトル, 力の種類)
        rb.AddForce(
            (transform.forward + transform.right) * speed, 
            ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
