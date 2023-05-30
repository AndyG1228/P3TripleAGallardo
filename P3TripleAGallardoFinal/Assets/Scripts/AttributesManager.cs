using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attack;
    public int maxHealth;


    Rigidbody2D rb;
    [SerializeField] FloatingHealthBar healthBar;

    //dont want the healthBar to be public. What do I do? That is what it is stopping me from putting this on the enemy. Without the script on the enmemy, the health bar wont update

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }


    public void TakeDamage (int amount)
    {
        health -= amount;
        healthBar.UpdateHealthBar(health, maxHealth);
    }


    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            atm.TakeDamage(attack);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
