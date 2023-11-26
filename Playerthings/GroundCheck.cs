using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool IsGrounded = false;

    // On ground
    private void OnTriggerEnter2D(Collider2D Ground) 
    {
        IsGrounded = true;
    }

    // Off ground
    private void OnTriggerExit2D(Collider2D Ground) 
    {
        IsGrounded = false;    
    }
}
