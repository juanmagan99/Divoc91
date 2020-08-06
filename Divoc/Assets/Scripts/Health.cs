using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int initialHealth = 5;

    public UnityEvent onDie = new UnityEvent();

    private int currentHealth;

    private void Start()
    {
        currentHealth = initialHealth;
    }

    public void Hit (int damage)
    {
        currentHealth = damage;

        if (currentHealth <= 0)
        {
            onDie.Invoke();
        }
    }
}
