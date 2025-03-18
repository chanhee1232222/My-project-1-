using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class randombox : MonoBehaviour
{
    public GameObject CoinPrefab;

    public bool isActibate = true;

    SpriteRenderer _sr;
    public Sprite unActivateBoxSpriteRendrer;

    private void Start()
    {
        _sr = GetComponentInParent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActibate)
        {
            Debug.Log("���� �ڽ��� �浹�߽��ϴ�.");
            
            isActibate = false;

            Instantiate(CoinPrefab, transform.position, Quaternion.identity);


            _sr.sprite = unActivateBoxSpriteRendrer;

            soundmanager.Instance.PlaySFX("coin");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("���� �ڽ��� �浹�� �������ϴ�.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("���� �ڽ��� �浹�� �������Դϴ�.");
    }
}
