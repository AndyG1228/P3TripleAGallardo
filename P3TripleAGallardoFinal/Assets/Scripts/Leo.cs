using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Leo : MonoBehaviour
{
    /*public int health;
    public int attack;
    public int maxHealth;*/

    public NavMeshAgent enemy;
    public Transform player;
    public GameObject leo;
    public GameObject taurus;

    public AttributesManager attributesManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);

        if (attributesManager.health <= 0)
        {
            leo.SetActive(false);
            taurus.SetActive(true);
        }


    }
}
