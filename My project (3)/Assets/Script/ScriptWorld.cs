using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptWorld : MonoBehaviour
{
    [SerializeField] private DestructiWorld _event;

    private void OnEnable()
    {
        DestructiWorld._world += Swed;
    }

    private void OnDisable()
    {
        DestructiWorld._world -= Swed;
    }

    private void Swed()
    {
        Destroy(gameObject);
    }
}