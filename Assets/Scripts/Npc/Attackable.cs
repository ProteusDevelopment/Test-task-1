using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackable : MonoBehaviour
{
    [SerializeField] private int _attackDamage = 20;
    [SerializeField] private float _attackRate = 0.5f;
    [SerializeField] private float _attackRadius = 1f;

    private Damagable _target;

    private float _attackTimer = 0;

	private void Update()
	{
		if (_target &&
			Vector3.Distance(transform.position, _target.transform.position) <= _attackRadius)
		{
			_attackTimer += Time.deltaTime;

			if (_attackTimer >= _attackRate)
			{
				_attackTimer -= _attackRate;
				HitTarget();
			}
		}
	}

	private void HitTarget()
	{
		_target.ApplyDamage(_attackDamage);
	}

	public void SetTarget(Damagable target)
	{
        _target = target;
	}

	public void ResetTarget()
	{
		SetTarget(null);
	}
}
