using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Colisiones : MonoBehaviour
{
    private void OnTriggerEnter(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("manzana"))
        {
            Debug.Log("Colision con comida");
            Destroy(collision.gameObject);
        }
    }
}
