using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAttacher : MonoBehaviour
{
    public void AttachRigidbody()
    {
        GameObject hill = FindObjectOfType<MeshGenerator>().gameObject;
        hill.AddComponent<Rigidbody>();
        hill.GetComponent<Rigidbody>().isKinematic = true;
    }
}
