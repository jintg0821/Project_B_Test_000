using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{

    float rotSpeed = 0;                         //변수 회전 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10000;
        }

        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);                 //transform은 캐릭터의 위치 컴퍼넌트
                                                                                //Rotate 함수는 회전을 시켜주는 함수
        rotSpeed *= 0.99f;                                                      //프레임마다 1%씩 속도 감소
    }
}
