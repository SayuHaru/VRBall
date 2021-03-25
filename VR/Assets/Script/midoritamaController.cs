using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class midoritamaController : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (Bottom.go == 10000)
        {
            if (other.gameObject.tag == "akakago")
            {
                audioSource.PlayOneShot(sound1);
                akatamaController.score = akatamaController.score + 50;
            }
            if (other.gameObject.tag == "aokago")
            {
                audioSource.PlayOneShot(sound2);
                akatamaController.score = akatamaController.score + 50;
            }
            if (other.gameObject.tag == "midorikago")
            {
                audioSource.PlayOneShot(sound1);
                akatamaController.score = akatamaController.score + 100;
            }
        }

        if (other.gameObject.tag == "akakago")
        {
            transform.parent = GameObject.Find("akakago").transform;
        }
        if (other.gameObject.tag == "aokago")
        {
            transform.parent = GameObject.Find("aokago").transform;
        }
        if (other.gameObject.tag == "midorikago")
        {
            transform.parent = GameObject.Find("midorikago").transform;
        }
    }
}
