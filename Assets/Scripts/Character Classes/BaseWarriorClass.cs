using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass()
	{
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A powerful and strong warrior that clubs you over the head";

		Stamina = 20;
		Endurance = 24;
		Strength = 20;
		Intellect = 10;
	}

}
