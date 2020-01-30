using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : ScriptableObject
{
    public string Name;
    public float DamageMultiplier;
    public float KnockbackMultiplier;
    public float MovementSpeed;
}
