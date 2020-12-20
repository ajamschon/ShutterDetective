using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DisparadorInteract : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactAction;
        
    void Start()
    {
        
    }

    void Update()
    {
        if(isInRange) //chequea rango distancia
       {
        interactAction.Invoke(); //dispara evento
       }
    }

    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.gameObject.CompareTag("Player")) 
        {
            isInRange = true;
        }   
    }
    private void OnTriggerExit(Collider collision) 
    {
        if(collision.gameObject.CompareTag("Player")) 
        {
            isInRange = false;
        }   
    }

}
