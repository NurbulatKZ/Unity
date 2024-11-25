using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.ShaderKeywordFilter;
using UnityEditor.VersionControl;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    
    void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
