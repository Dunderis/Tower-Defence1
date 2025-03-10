using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public UnityEvent<int, int> OnHealthChanged;
    public UnityEvent OnDeath;
    public bool destroyOnDeath;
    
    private int currentHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        OnHealthChanged.Invoke(currentHealth, maxHealth);
        if (currentHealth == 0)
        {
            OnDeath.Invoke();
            if(destroyOnDeath) Destroy(gameObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        print(currentHealth);
    }
}