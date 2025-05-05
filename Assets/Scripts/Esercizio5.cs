using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{

    public int partenza = 4; 


    // Start is called before the first frame update
    void Start()
    {
        Stampa25successivi()
    }

    // Update is called once per frame
    void Update()
    {
        void Stampa25successivi()
        {
            Debug.Log("partenza -> " + partenza + " successivo -> " + (partenza + 1).ToString() + " successivo -> " + (partenza + 2).ToString());
        }
}
