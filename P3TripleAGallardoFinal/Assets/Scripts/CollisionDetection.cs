using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    //creating variables
    public WeaponController wc;
    public GameObject HitParticle;
    public AudioClip HammerAttackSound;
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;


    //when enemy is being attacked, its health will decline
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && wc.IsAttacking)
        {
            playerAtm.DealDamage(enemyAtm.gameObject);

            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");

            Instantiate(HitParticle, new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z),
            other.transform.rotation);

            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(HammerAttackSound);


            
        }

        

    }
    



    void Start()
    {
        
    }

   
    void Update() //click f12 to deplete player's health
    {
        if (Input.GetKeyDown(KeyCode.F12))
            {
                enemyAtm.DealDamage(playerAtm.gameObject);
            }
    }
}
