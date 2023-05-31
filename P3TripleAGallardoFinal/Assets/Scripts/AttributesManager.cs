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


    public void RestartCurrentLevel() //testing -> not complete. 
    {
        if (health >= 0)
        {
            Debug.Log("GameOver");
        }
    }

    



    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
