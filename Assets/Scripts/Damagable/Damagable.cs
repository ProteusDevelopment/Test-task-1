using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Damagable : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    [SerializeField] private int _currentHealth = 100;

    [SerializeField] private HealthView _healthPresenter;

    protected virtual void Start()
	{
        _healthPresenter.SetMaxHealth(_maxHealth);
        UpdateHealthPresenter();
    }

    protected void ResetHealth()
	{
        _currentHealth = _maxHealth;
        UpdateHealthPresenter();
    }

    protected void UpdateHealthPresenter()
	{
        _healthPresenter.UpdateHealth(_currentHealth);
	}

    public void ApplyDamage(int damage)
	{
        _currentHealth -= damage;
        UpdateHealthPresenter();

        if (_currentHealth <= 0)
        {
            Death();
        }
	}

    public abstract void Death();
}
