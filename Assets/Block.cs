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

    // OnCollisionEnter�̓R���C�_�[�ɑ��̃I�u�W�F�N�g�������������ɌĂяo�����
    // �����ɂ͓����������̃I�u�W�F�N�g������
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);    // �u���b�N���폜
    }
}
