using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpectedBehaviour : MonoBehaviour
{
    [SerializeField] private Npc _npc1;
    [SerializeField] private Npc _npc2;
    [SerializeField] private Damagable _cubeEnemy;

    private bool _npc1Attacking = true;

	private void Start()
	{
        _npc1.Attackable.SetTarget(_cubeEnemy);
	}

	public void Swap()
	{
        _npc1.Movable.MoveTo(_npc2.transform.position);
        _npc2.Movable.MoveTo(_npc1.transform.position);

        _npc1Attacking = !_npc1Attacking;

        if (_npc1Attacking)
		{
            _npc1.Movable.OnReached.AddListener(Npc1_Attack_OnReached);
            _npc2.Movable.OnReached.RemoveListener(Npc2_Attack_OnReached);
            _npc2.Attackable.ResetTarget();
		}
		else
		{
            _npc2.Movable.OnReached.AddListener(Npc2_Attack_OnReached);
            _npc1.Movable.OnReached.RemoveListener(Npc1_Attack_OnReached);
            _npc1.Attackable.ResetTarget();
        }
	}

    private void Npc1_Attack_OnReached()
	{
        _npc1.Attackable.SetTarget(_cubeEnemy);
	}

    private void Npc2_Attack_OnReached()
    {
        _npc2.Attackable.SetTarget(_cubeEnemy);
    }
}
