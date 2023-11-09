using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Send : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Receive.send){
            if(Random.value > 0.5f){
                Receive.receive = true;
            }else{
                Receive.receive = false;
            }
        }
    }
}
