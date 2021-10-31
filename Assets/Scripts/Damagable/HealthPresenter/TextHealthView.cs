using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHealthView : HealthView
{
	[SerializeField] private Text _healthText;

	public override void SetMaxHealth(int maxHealth)
	{
		
	}

	public override void UpdateHealth(int health)
	{
		_healthText.text = health.ToString();
	}
}
