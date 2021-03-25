using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    public GameObject Botton;
    public GameObject BGM;
    public static int go = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        go = 10000;
        BGM.SetActive(true);
        Botton.SetActive(false);
       
    }
    }
