using System.Collections.Generic;

public class PlayerStat
{
	private Dictionary<string, float> _modifiers = new();
	public float Base { get; private set; }
	public float Current { get; private set; }

	public void ApplyBase(float value)
	{
		Base = value;
		RecalculateCurrent();
	}
	
	private void RecalculateCurrent()
	{
		var result = Base;

		foreach (var modifierValue in _modifiers.Values)
		{
			result *= modifierValue;
		}

		Current = result;
	}

	public void AddModifier(string modifierId, float modifier)
	{
		_modifiers.Add(modifierId, modifier);
		RecalculateCurrent();
	}
}
