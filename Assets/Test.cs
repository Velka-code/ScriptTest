using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
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

    }

    void Update()
    {

    }
}