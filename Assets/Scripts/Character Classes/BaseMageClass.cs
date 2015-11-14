using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {
	
	public BaseMageClass()
	{
		CharacterClassName = "Mage";
		CharacterClassDescription = "A smart and mystic mage";
		
		Stamina = 12;
		Endurance = 10;
		Strength = 10;
		Intellect = 35;
	}

}
