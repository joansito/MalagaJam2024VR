using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desactivaranimacion : MonoBehaviour
{
Animator numero;
    
     void Start()
    {
        numero = gameObject.GetComponent<Animator>();
        
    }
    
    public void DesactAnim()
    {
        
             numero.enabled = false; 

    }
}
