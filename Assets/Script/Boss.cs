using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 課題対象クラス
/// </summary>
public class Boss : MonoBehaviour
{
    int mp;
    static int MPCOST = 5;

    // Start is called before the first frame update
    void Start()
    {
        //　要素5 array 
        int[] array = { 1, 2, 3, 4, 5 };

        Debug.Log("<color=green>正順表示</color>");
        for (int i = 0; i < array.Length; i++)
            Debug.Log(array[i]);

        Debug.Log("<color=green>逆順表示</color>");
        for (int i = array.Length-1; i >= 0 ; i--)
            Debug.Log(array[i]);

        // 課題用の初期化
        mp = 53;

        // 魔法を10回打つ
        for(int i=0; i<10; i++)
            mp = Magic(mp);

        // 魔法を1回打つ
        mp = Magic(mp);
    }

    // 使用するとコストを5消費する関数として定義
    private int Magic(int mp)
    {
        if (mp >= MPCOST)
        {
            mp -= MPCOST;
            Debug.Log($"魔法攻撃をした。残りMPは{mp}");
            return mp;
        }

        Debug.Log("<color=red>MPが足りないため、魔法が使えない。</color>");
        return mp;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
