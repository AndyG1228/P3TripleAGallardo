using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class Taurus : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;
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
            SceneManager.LoadScene("Space");
        }

    }
}
