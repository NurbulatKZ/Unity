using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mover : MonoBehaviour
{
   [SerializeField] float moveSpeed = 10f;
 
 // quick from point a to point b without per frame moving
    void Start()
    {
        PrintInstruction();
    }

// Update per frame
    void Update()
    {
        MovePlayer();
    }
    
    void PrintInstruction()
    {
        Debug.Log("Welcome to the game dude!");
        Debug.Log("User W A S D buttons to ride a car!");
        Debug.Log("Do not bump into objects!");
    }

    void MovePlayer()
    {
         // data type and data values
    float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float yValue = 0f;
    float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(xValue, yValue, zValue);
    }



}
