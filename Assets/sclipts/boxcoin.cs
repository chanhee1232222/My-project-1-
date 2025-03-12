using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxcoin : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float PopPower = 2.5f;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.AddForce(Vector2.up * PopPower, ForceMode2D.Impulse);

        Invoke(nameof(DisableObject),1.5f);
        Destroy(gameObject, 2f);
    }

    private void DisableObject()
    {
        gameObject.SetActive(false);
    }
}
