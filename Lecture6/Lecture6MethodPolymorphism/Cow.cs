using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6MethodPolymorphism;


public class Cow : Animal
{
	public string DoSound()
	{
		return "MOOO!";
	}


	public bool DoesEat(string food)
	{
		return food == "grass";
	}
}
