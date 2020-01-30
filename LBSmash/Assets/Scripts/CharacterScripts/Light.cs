using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Light", menuName = "Characters/Light")]
public class Light : Character
{
    [HideInInspector] public float Stamina;

    public Image icon;
}
