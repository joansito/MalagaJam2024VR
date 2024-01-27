using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirtelon : MonoBehaviour
{
    Animator telon;
    
     void Start()
    {
        telon = gameObject.GetComponent<Animator>();
        
    }
    
    public void SubirTelon()
    {
        
             telon.SetBool("subir", true);
             Destroy (gameObject, 5);

    }
}
