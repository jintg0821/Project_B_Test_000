using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public int Monster_hp = 5;

    public void Monster_Damaged(int damage)     //데미지 받는 함수 (인수 int)
    {
        Monster_hp -= damage;                   //데미지를 뺀다.

        if(Monster_hp <= 0)
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }
    }
}
