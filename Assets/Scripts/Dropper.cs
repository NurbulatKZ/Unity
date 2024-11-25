using System.ComponentModel;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timer = 0.5f;
    MeshRenderer MyMeshRenderer; 
    Rigidbody MyRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyMeshRenderer = GetComponent<MeshRenderer>();
        MyRigidBody = GetComponent<Rigidbody>();
        MyMeshRenderer.enabled = false;
        MyRigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer)
        {
         MyMeshRenderer.enabled = true;
         MyRigidBody.useGravity = true;
        }
        
    }

}
