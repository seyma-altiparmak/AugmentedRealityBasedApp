using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] GameObject myCube;
    [SerializeField] float rotationSpeed;
    private Vector3 turnRotation;
    private void Awake()
    {
        turnRotation = Vector3.forward;
        myCube = FindAnyObjectByType<CubeObject>().gameObject;
    }

    private void Update()
    {
        myCube.transform.Rotate(turnRotation * rotationSpeed * Time.deltaTime);
    }
}
