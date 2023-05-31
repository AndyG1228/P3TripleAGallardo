using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sun : MonoBehaviour
{
    public GameObject winScreen;
    public AttributesManager attributesManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (attributesManager.health <= 0)
        {
            winScreen.gameObject.SetActive(true);
        }
    }
}
