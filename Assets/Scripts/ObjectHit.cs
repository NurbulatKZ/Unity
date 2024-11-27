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
        if (other.gameObject.tag == "Player")
        {
        GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit";
        }
    }
}
