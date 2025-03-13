using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public GameObject clreinfoobjerct;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        clreinfoobjerct.SetActive(true);
    }
}
