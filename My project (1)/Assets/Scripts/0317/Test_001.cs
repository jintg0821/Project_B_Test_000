using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;             //정수형 int 선언 이름은 age
        age = 30;            //age에 30 입력 (=) 입력
        Debug.Log(age);      //Console.log 창에 age의 값을 보여준다.

        float height1 = 160.5f; //부동소수점형 float 선언 이름은 height 이고 160.5f 입력
        float height2;        //float 형 height2 선언
        height2 = height1;  //height1에 있는 height2에 입력
        Debug.Log(height2); //Console.log 창에 height2 의 값을 보여준다.

        string name;        //문자열 name 선언
        name = "Sera";      //name Sera 입력
        Debug.Log(name);    //Console.log 창에 name 의 값을 보여준다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
