using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{

    public int num1 = 4;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 % 2 == 0)
        {
            Debug.Log("numero è pari");
        }
        else
            Debug.Log("numero è dispari");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
