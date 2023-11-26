using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFrameLock : MonoBehaviour
{
    public bool IsGrounded = false;

    private void OnTriggerEnter2D(Collider2D Ground) 
    {
        IsGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D Ground) 
    {
        IsGrounded = false;    
    }
}
