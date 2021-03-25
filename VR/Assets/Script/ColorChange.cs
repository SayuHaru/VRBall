using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public GameObject yellow;
    public GameObject red;
    public GameObject finish;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Bottom.go);
       if (Timer.timer <= 0.5f) {           
            yellow.SetActive(true);
        }
        if (Timer.timer <= 0.25)
        {
            red.SetActive(true);
        }
        if (Timer.timer == 0.0f)
        {
            Bottom.go = 0;
            finish.SetActive(true);
        }
    }
}
