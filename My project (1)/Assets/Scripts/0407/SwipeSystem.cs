using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    public Vector2 initialPos;                       //마우스는 화면인 x,y 포지션만 있기 때문에 Vector2
    public GameObject Character;                     //캐릭터를 선언한다. (GameObject)

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);
    }

    void Calculate(Vector3 finalPos)                //계산하는 함수를 만든다.
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);          //Mathf.abs 함수는 절대값을 구하는 함수 (거리를 구해야 하기 때문에)
        float disY = Mathf.Abs(initialPos.y - finalPos.y);          

        if (disX > 0 || disY > 0)                                   // || <- or을 나타내는 것 (&&)
        {
            if(disX > disY)
            {
                if(initialPos.x > finalPos.x)
                {
                    Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
                }
            }
            else
            {
                if(initialPos.y > finalPos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);
                }
            }
        }  
    }
}
