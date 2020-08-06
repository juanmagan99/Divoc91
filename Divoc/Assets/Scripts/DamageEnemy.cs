using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public int DamagePoints = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health healthCollision = collision.gameObject.GetComponent<Health>();
        if (healthCollision != null)
        {
            healthCollision.Hit(GetComponent<DamageEnemy>().DamagePoints);
           // Destroy(gameObject);
        }
    }



}
