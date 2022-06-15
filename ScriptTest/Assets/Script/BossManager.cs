using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 課題対象外
/// </summary>
public class BossManager
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
}
