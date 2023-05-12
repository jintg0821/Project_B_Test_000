using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;                  //Dotween�� ���� ���� ����

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;            //��Ī���ΰ� �˻��ϱ� ���� bool
    Sequence sequenceLoop;
    void Start()
    {
        //transform.DOMoveX(5, 2);                    //X������ 5��ŭ 2�� ���� �̵�
        //transform.DORotate(new Vector3(0, 0, 180), 2);  //Z������ 180�� ȸ��
        //transform.DOScale(new Vector3(2, 2, 2), 2);     //2��� 2�ʵ���

        //Sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2)); 
        //sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2).OnComplete(SequenceEnd));

        //sequence sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2).SetEase(Ease.OutBounce));
        //sequence.SetLoops(-1, LoopType.Yoyo);
        //sequenceLoop.Kill();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isPunch)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f),
                    0.1f, 10, 1).OnComplete(EndPunch);
            }
        }
    }

    void EndPunch()
    {
        isPunch = false;
    }
    void SequenceEnd()
    {
        gameObject.SetActive(false);
    }

    
}