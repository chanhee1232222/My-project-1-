using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randombox : MonoBehaviour
{
    public GameObject CoinPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("�����ڽ��� �浹�߽��ϴ�.");

        Instantiate(CoinPrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("�����ڽ��� �浹�� �������ϴ�.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("�����ڽ��� �浹�� �������Դϴ�.");
    }
}
