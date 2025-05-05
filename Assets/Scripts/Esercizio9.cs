using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio9 : MonoBehaviour
{
    public int a = 4;
    public int b = 5;

    // Start is called before the first frame update
    void Start()
    {
        MinoreTra2(a, b);
    }

    // Update is called once per frame
    void Update()
    {
        void MinoreTra2(int a, int b);

        if (a > b)
            Debug.Log("a è maggiore di b");
        else
            Debug.Log("b è maggiore di a");
    }
}
