using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]

public class AndroidScript : MonoBehaviour
{
    [SerializeField] private float _speedAndroid;

    [SerializeField] private Camera _camera2;

    private Rigidbody _rgAndroid;

    private void Start()
    {
        _rgAndroid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float _hAndroid = Input.GetAxis("Horizontal") * _speedAndroid * Time.deltaTime;
        float _vAndroid = Input.GetAxis("Vertical") * _speedAndroid * Time.deltaTime;

        _rgAndroid.velocity = transform.TransformDirection(new Vector3(_hAndroid, _rgAndroid.velocity.y, _vAndroid));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out DeathAndroid deathAndroid))
        {
            Destroy(gameObject);
            _camera2.gameObject.SetActive(true);
        }
    }
}
