using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGoldGenerator : MonoBehaviour
{
    public GameObject tamaPrefab;
    float span = 10.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Bottom.go == 10000)
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(tamaPrefab) as GameObject;
                float px = Random.Range(0.8f, 1.5f);
                float pz = Random.Range(0.2f, 0.45f);
                go.transform.position = new Vector3(px, 0.05f, pz);
            }
        }
    }
}
