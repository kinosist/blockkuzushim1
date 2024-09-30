using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.0f;     // �v���C���[�̃X�s�[�h

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �E�ړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // �E���L�[�������ꂽ�ꍇ
            // �v���C���[�̈ʒu���E�Ɉړ�
            // transform.position.x �v���C���[��x���W��4�����̏ꍇ�Ɉړ�
            if (transform.position.x < 4)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
        // ���ړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // �����L�[�������ꂽ�ꍇ
            // �v���C���[�̈ʒu�����Ɉړ�
            // transform.position.x �v���C���[��x���W��-4���̏ꍇ�Ɉړ�
            if (transform.position.x > -4)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
    }
}
