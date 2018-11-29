using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public const int maxHealth = 100;
    public int currentHealth = maxHealth;
    public int Lives;
    public void TakeDamage(int amount)
    
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {

            currentHealth = 0;
            Debug.Log("Dead!");
            Lives --;
            
        }
    }
    public void TakeLive(int amount)
    {
        if (Lives == 0)
        {
            
            Debug.Log("No more Lives");
        }
    }
}
