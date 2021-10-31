using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
public class Movable : MonoBehaviour
{
	private bool _isReached = true;
    private NavMeshAgent _agent;

	public UnityEvent OnReached = new UnityEvent();

	private void Start()
	{
		_agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		if (!_isReached && !_agent.pathPending &&
			_agent.remainingDistance <= _agent.stoppingDistance &&
			_agent.velocity.sqrMagnitude == 0f)
		{
			_isReached = true;
			OnReached.Invoke();
		}
	}

	public void MoveTo(Vector3 targetPosition)
	{
		_agent.SetDestination(targetPosition);
		_isReached = false;
	}
}
