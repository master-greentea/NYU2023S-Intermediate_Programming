using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) Destroy(gameObject);
    }

    private void SetPosition()
    {
        Vector3 newPos = new Vector3(2.25f, 1.95f, -3.66f);
        transform.position = newPos;
    }
}
