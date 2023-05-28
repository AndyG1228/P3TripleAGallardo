using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public WeaponController wc;
    public GameObject HitParticle;
    public AudioClip HammerAttackSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && wc.IsAttacking)
        {
            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");

            Instantiate(HitParticle, new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z),
            other.transform.rotation);

            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(HammerAttackSound);
        }
    }

    //Input a script that checks if the player collided with the enemy
        //if player collides with the enemy
                //take damage (take damage player script)


    //make a take damage player script 



    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
