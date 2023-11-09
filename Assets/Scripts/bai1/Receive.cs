using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receive : MonoBehaviour
{
    public static bool send;
    public static bool receive;
    public int numberOfSendTrue;
    
    public int numberOfSendFalse;
    public Renderer render;
    public Color newColor;

    void Start()
    {
        render = GetComponent<Renderer>();
        receive = false;
        numberOfSendTrue = 0;
        numberOfSendFalse = 0;
        send = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (send)
        {
            if (receive){
                numberOfSendTrue++;
                if (numberOfSendTrue == 500)
                {
                    newColor = Color.red;
                    render.material.color = newColor;
                }
                if (numberOfSendTrue == 700)
                {
                    newColor = Color.yellow;
                    render.material.color = newColor;
                }
                if (numberOfSendTrue == 1000)
                {
                    newColor = Color.green;
                    render.material.color = newColor;
                }

                if (numberOfSendTrue == 1200)
                {
                    send = false;
                }
                Debug.Log("I have received " + numberOfSendTrue + " messages from the Send script");
            }
            else
            {
                numberOfSendFalse++;
                Debug.Log("No messages received "+numberOfSendFalse);
            } 
        }
        
    }
}
