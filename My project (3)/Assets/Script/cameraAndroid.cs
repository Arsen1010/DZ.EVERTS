using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAndroid : MonoBehaviour
{
    [SerializeField] private float _sensitivityCamera;

    private const string _lineX = "Mouse X";
    private const string _lineY = "Mouse Y";

    private float _mouseX;
    private float _mpuseY;
    private float _rotationX = 0.0f;
    private int _maxRotation = 45;
    private int _minRotation = -45;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _mouseX = Input.GetAxis(_lineX);
        _mpuseY = Input.GetAxis(_lineY);

        transform.parent.Rotate(Vector3.up * _mouseX * _sensitivityCamera * Time.deltaTime);

        _rotationX -= _mpuseY * _sensitivityCamera * Time.deltaTime;
        _rotationX = Mathf.Clamp(_rotationX, _minRotation, _maxRotation);
        transform.localRotation = Quaternion.Euler(_rotationX, 0f, 0f);
    }
}
