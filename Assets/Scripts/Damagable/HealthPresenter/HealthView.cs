using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    public abstract void SetMaxHealth(int maxHealth);
    public abstract void UpdateHealth(int health);
}
