namespace Lecture18;


public interface Log
{
	void AttackHit(Character source, Character target, int damageRoll);

	void AttackMiss(Character source, Character target);

	void CharacterAttack(Character source, Character target, int attackRoll);

	void CharacterDoesNothing(Character character);

	void CharacterStatus(Character character);

	void CharacterTurn(Character character);

	void CharacterWait(Character character, int waitRoll);

	void GameOver(Character? winner);

	void GameStart(Character characterOne, Character characterTwo);
}