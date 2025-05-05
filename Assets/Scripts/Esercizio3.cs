using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{

    [SerializedField]
    privete int num1 = 5;

    [SerializedField]
    privete int num2 = 1;

    [SerializedField]
    privete int num3 = 5;

    [SerializedField]
    privete int num4 = 3;

    private int somma = 0;
    private int prodotto;
    private int media;
    // Start is called before the first frame update
    void Start()
    {
        somma = num1 + num2 + num3 + num4;
        prodotto = num1 * num2 * num3 * num4;
        media = (num1 + num2 + num3 + num4) / 4;
        Debug.Log("somma -> " + somma); 
        Debug.Log("prodotto -> " + prodotto);
        Debug.Log("media -> " + media);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
