using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test : MonoBehaviour
{
    //private int _score;
    //private int a;
    //private int b;
    //private int c;
    //private int _money;
    [SerializeField] BossManager lastBoss;
    [SerializeField] BossManager midboss;

    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log("Hello, World");

        //_score = 150;
        //Debug.Log(_score);

        //(a, b) = (3, 4);
        //c = a + b;
        //Debug.Log(c);

        //_money = 100;
        //PurchaseOrSellItem(_money);

        int num = 1;
        int val = (num == 1) ? -100 : 100;
        Debug.Log(val);

        //int val;
        //int num = 1;
        //if (num == 1)
        //{
        //    val = -100;
        //}
        //else
        //{
        //    val = 100;
        //}
        //Debug.Log(val);

        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}

        //// sumð0Åú»·é
        //int sum = 0;
        //// 10ñðJèÔ·
        //for (int i = 1; i <= 10; i++)
        //{
        //    // iÌlðsumÉ«·
        //    sum += i;
        //}
        //// sumÌlð\¦·é
        //Debug.Log(sum);

        //int[] points = new int[5];

        //points[0] = 30;
        //points[1] = 20;
        //points[2] = 50;
        //points[3] = 10;
        //points[4] = 80;
        //points = [30, 20, 50, 10, 80];

        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(points[i]);
        //}

        //// zñðú»
        //int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        //for (int i = 0; i < points.Length; i++)
        //{
        //    if (points[i] >= 50)
        //    {
        //        Debug.Log(points[i]);
        //    }
        //}

        //foreach(var point in points.Where(n  => n>=50))
        //    Debug.Log(point);

        //Add(1, 2);

        lastBoss = new BossManager();
        lastBoss.Attack();
        lastBoss.Defence(3);

        midboss = new BossManager();
        midboss.Attack();
        midboss.Defence(1);

    }

    void PurchaseOrSellItem(int money)
    {
        //if (money >= 100)
        //    Debug.Log("|[Vð¤");
        //else
        //    Debug.Log("íðé");

        //if (money <= 50)
        //    Debug.Log("íðé");
        //else if (money >= 200)
        //    Debug.Log("íð¤");
        //else
        //    Debug.Log("|[Vð¤");

        //string message = money switch
        //{
        //    >= 200 => "íð¤",
        //    <= 50 => "íðé",
        //    _ => "|[Vð¤"
        //};

        Debug.Log(
            money switch
            {
                <= 50   => "íðé",
                >= 200  => "íð¤",
                _       => "|[Vð¤"
            }
        );

    }

    int Add(int a, int b) => a + b;

    // Update is called once per frame
    void Update()
    {

    }

}
