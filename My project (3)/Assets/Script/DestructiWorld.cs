using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class DestructiWorld : MonoBehaviour
{
    public static event Action _world;
    public static event Action _colosss;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ButtonWorld")
        {
            _world?.Invoke();
        }

        if(collision.gameObject.name == "ButtonColors") 
        { 
            _colosss?.Invoke();
        }
    }
}
