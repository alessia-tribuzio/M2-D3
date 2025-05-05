using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio10 : MonoBehaviour
{
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; 

        If (time < 30)
            Debug.Log("sono trascorsi meno di 30 secondi")
       else if (time > 30)
            Debug.Log("sono trascorsi più di 30 secondi")
       else if (time > 45)
            Debug.Log("sono trascorsi più di 30 secondi")
       else if (time > 60)
            Debug.Log("sono trascorsi più di un minuto")


        Debug.Log("time ->" + time);


    }
}
