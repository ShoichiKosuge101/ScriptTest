using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ۑ�ΏۊO
/// </summary>
public class BossManager
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }
}
