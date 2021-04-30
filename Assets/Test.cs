using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    //変数mpを宣言し、53で初期化
    private int mp = 53;

    public void Magic(int down)
    {
        if(down >= 5)
        {
            if (this.mp  > 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは"+ this.mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
            
        }
        else
        {
            if(this.mp > down)
            {
                this.mp -= down;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
            
        }
        
    }
}


public class Test : MonoBehaviour
{

    void Start()
    {
        /*
        //配列arrayを宣言し、初期化
        int[] array = { 8, 6, 3, 4, 7 };

        //配列の各要素を順番に表示
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の各要素を逆順に表示
        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        */

        int[] value = { 3, 10, 8, 1, 10, 7, 20, 23, 1, 3 , 40 , 50 };


        Boss boss = new Boss();

        for (int i = 0; i < value.Length; i++)
        {
            int num = i + 1;

            if (num <= 10) 
            {
                Debug.Log(num + "回目の魔法攻撃:" + value[i]);
                boss.Magic(value[i]);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
                break;
            }
            
        }

    }

    void Update()
    {

    }
}