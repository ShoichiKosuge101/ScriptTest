using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ۑ�ΏۃN���X
/// </summary>
public class Boss : MonoBehaviour
{
    int mp;
    static int MPCOST = 5;

    // Start is called before the first frame update
    void Start()
    {
        //�@�v�f5 array 
        int[] array = { 1, 2, 3, 4, 5 };

        Debug.Log("<color=green>�����\��</color>");
        for (int i = 0; i < array.Length; i++)
            Debug.Log(array[i]);

        Debug.Log("<color=green>�t���\��</color>");
        for (int i = array.Length-1; i >= 0 ; i--)
            Debug.Log(array[i]);

        // �ۑ�p�̏�����
        mp = 53;

        // ���@��10��ł�
        for(int i=0; i<10; i++)
            mp = Magic(mp);

        // ���@��1��ł�
        mp = Magic(mp);
    }

    // �g�p����ƃR�X�g��5�����֐��Ƃ��Ē�`
    private int Magic(int mp)
    {
        if (mp >= MPCOST)
        {
            mp -= MPCOST;
            Debug.Log($"���@�U���������B�c��MP��{mp}");
            return mp;
        }

        Debug.Log("<color=red>MP������Ȃ����߁A���@���g���Ȃ��B</color>");
        return mp;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
