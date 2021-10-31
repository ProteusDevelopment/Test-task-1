using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnemy : Damagable
{
	public override void Death()
	{
		ResetHealth();
	}
}
