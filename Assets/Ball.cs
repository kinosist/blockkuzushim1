using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 1.0f;     // �{�[���̃X�s�[�h
    private Rigidbody rb;          // Rigidbody�R���|�[�l���g

    // Start is called before the first frame update
    void Start()
    {
        // �{�[����Rigidbody�R���|�[�l���g���擾
        rb = GetComponent<Rigidbody>();
        // �Q�[���J�n���Ƀ{�[�����E�O�ɓ�����
        // AddForce(�x�N�g��, �͂̎��)
        rb.AddForce(
            (transform.forward + transform.right) * speed, 
            ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
