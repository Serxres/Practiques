using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchCamera : MonoBehaviour
{
    private Camera canvasCam;
    private Canvas menu;
    // Start is called before the first frame update
    void Start()
    {
        canvasCam = GameObject.FindGameObjectWithTag("Player").GetComponent<Camera>();
        menu.worldCamera = canvasCam;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
