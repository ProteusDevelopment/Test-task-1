using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    [SerializeField] private Transform _target;

	private void Update()
	{
		transform.rotation = _target.rotation;
	}
}
