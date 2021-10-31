using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Movable))]
[RequireComponent(typeof(Attackable))]
public class Npc : MonoBehaviour
{
	private Movable _movable;
	private Attackable _attackable;

	public Movable Movable => _movable;
	public Attackable Attackable => _attackable;

	private void Awake()
	{
		_movable = GetComponent<Movable>();
		_attackable = GetComponent<Attackable>();
	}
}
