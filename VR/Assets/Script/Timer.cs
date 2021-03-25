using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Image UIobj;
    public Image UIobj2;
    public Image UIobj3;
    public bool roop;
    public float countTime = 50.0f;
    public static float timer = 1;
    // Update is called once per frame
    void Update()
    {
        if (Bottom.go == 10000) {
            UIobj.fillAmount -= 1.0f / countTime * Time.deltaTime;
            timer = UIobj.fillAmount;
            UIobj2.fillAmount -= 1.0f / countTime * Time.deltaTime;
            UIobj3.fillAmount -= 1.0f / countTime * Time.deltaTime;
        }
      }
}
