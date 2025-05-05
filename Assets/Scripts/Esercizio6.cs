using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stampa2Precedenti();
    }

    // Update is called once per frame
    void Update()
    {
        void Stampa2Precedenti()
        {
            Debug.Log("partenza -> " + partenza + " precedente -> " + (partenza - 1).ToString() + " precedente -> " + (partenza - 2).ToString());
        }

    }
}
