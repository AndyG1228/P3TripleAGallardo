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
    public AttributesManager leoAtm;
    public AttributesManager taurAtm;
    public AttributesManager sunAtm;

    //when enemy is being attacked, its health will decline
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && wc.IsAttacking)
        {
            playerAtm.DealDamage(leoAtm.gameObject);

            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");

            Instantiate(HitParticle, new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z),
            other.transform.rotation);

            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(HammerAttackSound);

            playerAtm.DealDamage(taurAtm.gameObject);


        }

        if (other.tag == "Sun" && wc.IsAttacking)
        {
            playerAtm.DealDamage(sunAtm.gameObject);

            Debug.Log(other.name);
            other.GetComponent<Animator>().SetTrigger("Hit");

            Instantiate(HitParticle, new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z),
            other.transform.rotation);

            AudioSource ac = GetComponent<AudioSource>();
            ac.PlayOneShot(HammerAttackSound);
        }

        if (other.tag == "Player")
        {
            leoAtm.DealDamage(playerAtm.gameObject);
            taurAtm.DealDamage(playerAtm.gameObject);
            sunAtm.DealDamage(playerAtm.gameObject);
        }

    }
    



    void Start()
    {
        
    }

   
    void Update() //click f12 to deplete player's health
    {
        if (Input.GetKeyDown(KeyCode.F12))
            {
                leoAtm.DealDamage(playerAtm.gameObject);
            }
    }
}
