using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColors : MonoBehaviour
{
    [SerializeField] private MeshRenderer _mesh;
    [SerializeField] private DestructiWorld _worlsGame;

    private void OnEnable()
    {
        DestructiWorld._colosss += GameColors;
    }

    private void OnDisable()
    {
        DestructiWorld._colosss -= GameColors;
    }

    private void GameColors()
    {
        _mesh.material.color = Random.ColorHSV();
    }
}
