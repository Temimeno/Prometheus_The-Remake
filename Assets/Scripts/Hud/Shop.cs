using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject Shopmanager,PressInterAct;
    
    // Start is called before the first frame update
    void Start()
    {
        Shopmanager.SetActive(false);
        PressInterAct.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Shopmanager.SetActive(true);
            PressInterAct.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Shopmanager.SetActive(false);
            PressInterAct.SetActive(false);
        }
    }

}
