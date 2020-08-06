using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    Transform target;

    private void Start()
    {
        target = FindObjectOfType<Shooting>().transform;
    }
    private void Update()
    {
        transform.Translate((target.position - transform.position).normalized * speed * Time.deltaTime, Space.World);
    }
}
