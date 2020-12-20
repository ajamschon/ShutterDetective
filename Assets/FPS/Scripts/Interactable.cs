using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    
    void Start()
    {
        
    }
    
    void Update()
    {
       if(isInRange) //chequea rango distancia
       {
           if(Input.GetKeyDown(interactKey)) //presion tecla
           {
               interactAction.Invoke(); //dispara evento
           }
       }
    }

    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.CompareTag("Player")) 
        {
            isInRange = true;
            Debug.Log("Player en rango");
        }   
    }
    private void OnTriggerExit(Collider collision) 
    {
        if(collision.gameObject.CompareTag("Player")) 
        {
            isInRange = false;
            Debug.Log("Player out del rango");
        }   
    }
}