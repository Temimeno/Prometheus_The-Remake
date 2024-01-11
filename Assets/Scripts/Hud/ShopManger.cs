using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManger : MonoBehaviour
{
    public GameObject ShopUi;
    // Start is called before the first frame update
    void Start()
    {
        ShopUi.SetActive(false);     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            ShopUi.SetActive(true);
        }
    }
    public void close()
    {
        ShopUi.SetActive(false);
    }
}
