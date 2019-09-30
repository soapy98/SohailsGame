using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createobject : MonoBehaviour
{
    public Transform Spawnpoint;
    public Rigidbody Prefab;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody RigidPrefab;
     RigidPrefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation)as Rigidbody;
    }
}
