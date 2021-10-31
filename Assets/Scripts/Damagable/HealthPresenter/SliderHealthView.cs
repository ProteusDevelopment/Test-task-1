using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHealthView : HealthView
{
	[SerializeField] private Slider _healthSlider;

	public override void SetMaxHealth(int maxHealth)
	{
		_healthSlider.maxValue = maxHealth;
	}

	public override void UpdateHealth(int health)
	{
		_healthSlider.value = health;
	}
}
