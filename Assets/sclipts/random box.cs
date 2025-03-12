using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randombox : MonoBehaviour
{
    public GameObject CoinPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("랜덤박스랑 충돌했습니다.");

        Instantiate(CoinPrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("램덤박스랑 충돌이 끝났습니다.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("랜덤박스랑 충돌이 진행중입니다.");
    }
}
