using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirTrampilla : MonoBehaviour
{
     Animator trampilla;
    
     void Start()
    {
        trampilla = gameObject.GetComponent<Animator>();
        
    }
    
    public void AbrirTramp()
    {
        
             trampilla.SetBool("abierta", true);

    }
}
