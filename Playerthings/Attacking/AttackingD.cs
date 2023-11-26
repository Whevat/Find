using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingD : MonoBehaviour
{
    public AttackingCtrl aC;
    public GroundCheck gC;

    public SpriteRenderer sR;

    bool attacking = false;

    private void Start() 
    {
        sR = GetComponent<SpriteRenderer>();    
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D) && gC.IsGrounded)
        {
            if (Input.GetKeyDown(KeyCode.L) && aC.canAttack)
            {
                StartCoroutine(attack(aC.attackingDelay));
            }    
            if (attacking)
            {
                sR.color = aC.Active;
            }
            else
            {
                sR.color = aC.Dormant;
            }
        }
    }

    IEnumerator attack (float wait)
    {
        attacking = true;
        aC.canAttack = false;
        
        yield return new WaitForSeconds(wait);

        attacking = false;
        aC.canAttack = true;
    }
}
