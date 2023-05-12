using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;     //�߻�ü ���⼺ ����

    public enum BULLETTYPE
    {
        PLAYER,
        ENEMY
    }

    public BULLETTYPE bulletType = BULLETTYPE.PLAYER;

    private void FixedUpdate()                              //�̵� ���� �Լ�
    {
        float moveAmount = 3 * Time.fixedDeltaTime;         //�߻�ü �̵� �ӵ�
        transform.Translate(launchDirection * moveAmount);  //�ش�������� �̵�
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);           //�浹�� �Ͼ�� �̸��� �����´�.

        if (collision.gameObject.name == "wall")
        {
            GameObject temp = this.gameObject;              //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                  //��ٷ� �ı��Ѵ�.
        }
        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;              //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                  //��ٷ� �ı��Ѵ�.
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;              //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                  //��ٷ� �ı��Ѵ�.
        }
        if (other.gameObject.tag == "Monster" && bulletType == BULLETTYPE.PLAYER)               //���Ϳ� �浹�� �Ͼ�� ��
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;              //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                  //��ٷ� �ı��Ѵ�.
        }

        if (other.gameObject.tag == "Player" && bulletType == BULLETTYPE.ENEMY)               //���Ϳ� �浹�� �Ͼ�� ��
        {
            other.gameObject.GetComponent<PlayerController>().Player_Damaged(1);
            GameObject temp = this.gameObject;              //�� �ڽ��� �����ͼ� temp �� �Է��Ѵ�.
            Destroy(temp);                                  //��ٷ� �ı��Ѵ�.
        }
    }
}
