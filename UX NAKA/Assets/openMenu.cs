using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMenu : MonoBehaviour
{
    public GameObject tabletMenu;
    public GameObject camera;
    public bool menuOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame<
    void Update()
    {
        if (Input.GetKeyDown("space") && menuOpen == false)
        {
             Instantiate(tabletMenu, camera.transform.position + (camera.transform.forward * 1.2f), camera.transform.rotation);
             menuOpen = true;
        }
    }
}
