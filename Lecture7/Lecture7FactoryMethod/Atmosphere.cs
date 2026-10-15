namespace Lecture7FactoryMethod;


class Atmosphere
{
	private float sunIntensity;

	private int oxygenAmount;

	private int co2Amount;


	public Atmosphere(int oxygenAmount, int co2Amount, float sunIntensity)
	{
		ArgumentOutOfRangeException.ThrowIfNegative(oxygenAmount);
		ArgumentOutOfRangeException.ThrowIfNegative(co2Amount);

		this.oxygenAmount = oxygenAmount;
		this.co2Amount = co2Amount;
		SunIntensity = sunIntensity;
	}


	public float SunIntensity
	{
		get => sunIntensity;
		set => sunIntensity = Math.Clamp(value, 0.0f, 1.0f);
	}


	public void IncreaseOxygen(int amount)
	{
		ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);

		oxygenAmount += amount;
	}


	public void DecreaseOxygen(int amount)
	{
		if (amount <= 0 || amount > oxygenAmount) {
			throw new ArgumentOutOfRangeException(nameof(amount));
		}

		oxygenAmount -= amount;
	}


	public void IncreaseCO2(int amount)
	{
		ArgumentOutOfRangeException.ThrowIfNegativeOrZero(amount);

		co2Amount += amount;
	}


	public void DecreaseCO2(int amount)
	{
		if (amount <= 0 || amount > co2Amount) {
			throw new ArgumentOutOfRangeException(nameof(amount));
		}

		co2Amount -= amount;
	}
}
