using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class DamageEnemy : MonoBehaviour
{
    public event Action<int> OnAttack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            DamageAllEnemies();
            //Debug.Log("Damage All Enemies");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            InvokeDamageAllEnemies();
        }
    }

    void DamageAllEnemies()
    {
         GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

         foreach (var enemy in enemies)
         {
             var health = enemy.GetComponent<Health>();

             if (health == null) return;
             
             health.TakeDamage(1);
         }
    }

    void InvokeDamageAllEnemies()
    {
        OnAttack?.Invoke(1);
    }
}
