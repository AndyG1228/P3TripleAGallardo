using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignProjectile : MonoBehaviour
{
    public float speed = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
