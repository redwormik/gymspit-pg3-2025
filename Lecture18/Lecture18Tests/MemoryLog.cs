namespace Lecture18Tests;

using Lecture18;


internal class MemoryLog : Log
{
	private List<object[]> logs = new();

	public object[][] Logs => [..logs];


	public void AttackHit(Character source, Character target, int damageRoll)
	{
		logs.Add(["AttackHit", source, target, damageRoll]);
	}


	public void AttackMiss(Character source, Character target)
	{
		logs.Add(["AttackMiss", source, target]);
	}


	public void CharacterAttack(Character source, Character target, int attackRoll)
	{
		logs.Add(["CharacterAttack", source, target, attackRoll]);
	}


	public void CharacterDoesNothing(Character character)
	{
		logs.Add(["CharacterDoesNothing", character]);
	}


	public void CharacterStatus(Character character)
	{
		logs.Add(["CharacterStatus", character]);
	}


	public void CharacterTurn(Character character)
	{
		logs.Add(["CharacterTurn", character]);
	}


	public void CharacterWait(Character character, int waitRoll)
	{
		logs.Add(["CharacterWait", character, waitRoll]);
	}


	public void GameOver(Character? winner)
	{
		logs.Add(["GameOver", winner]);
	}


	public void GameStart(Character characterOne, Character characterTwo)
	{
		logs.Add(["GameStart", characterOne, characterTwo]);
	}
}
