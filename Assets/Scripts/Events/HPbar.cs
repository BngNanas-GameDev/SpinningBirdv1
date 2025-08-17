using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class HPbar : MonoBehaviour
{
    [SerializeField] private float HP = 100f;
    [SerializeField] private float currentHP;
    public UnityEvent onDied;

    public float max => HP;
    public float current => currentHP;
    public float Normalisasi => Mathf.Infinity.Equals(HP) ? 1f : Mathf.Clamp01(currentHP / HP);
    public bool IsDead => currentHP <= 0f;

    private void Awake()
    {
        currentHP = HP;

    }
    public void TakeDamage(float amount)
    {
        if (IsDead) return;
        currentHP = Mathf.Max(0f, currentHP - Mathf.Abs(amount));
        if (IsDead) onDied?.Invoke();

    }
    public void Heal(float amount)
    {
        if (IsDead) return;
        currentHP = Mathf.Min(HP, currentHP + Mathf.Abs(amount));

    }
    public void ResetHealth()
    {
        currentHP = HP;

    }
}