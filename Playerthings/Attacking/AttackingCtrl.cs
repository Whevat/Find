using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingCtrl : MonoBehaviour
{
    public Color32 Active = new Color32(255, 0, 0, 255);
    public Color32 Dormant = new Color32(255, 255, 255, 255);

    public float attackingDelay = 1.5f;
    public bool canAttack = true;
}
