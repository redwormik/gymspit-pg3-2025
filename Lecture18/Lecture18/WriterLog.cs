namespace Lecture18;


public class WriterLog : Log
{
	private TextWriter writer;


	public WriterLog(TextWriter writer)
	{
		this.writer = writer;
	}


	public void GameStart(Character characterOne, Character characterTwo)
	{
		writer.WriteLine("Let the games begin!");
		CharacterStatus(characterOne);
		CharacterStatus(characterTwo);
	}


	public void GameOver(Character? winner)
	{
		writer.WriteLine();

		if (winner == null) {
			writer.WriteLine("The game is a draw");
		} else {
			writer.WriteLine($"{winner.Name} wins the game!");
		}

		writer.WriteLine();
		writer.WriteLine();
	}


	public void CharacterTurn(Character character)
	{
		writer.WriteLine();
		writer.WriteLine($"It is {character.Name}'s turn");
	}


	public void CharacterStatus(Character character)
	{
		writer.WriteLine($"{character.Name}: {(character.Alive ? "alive" : "dead")}, {character.HealthRatio:P0} health");
	}


	public void CharacterAttack(Character source, Character target, int attackRoll)
	{
		writer.WriteLine($"{source.Name} attacks {target.Name} (roll: {attackRoll})");
	}


	public void CharacterWait(Character character, int waitRoll)
	{
		writer.WriteLine($"{character.Name} waits (roll: {waitRoll})");
	}


	public void CharacterDoesNothing(Character character)
	{
		writer.WriteLine($"{character.Name} does nothing...");
	}


	public void AttackMiss(Character source, Character target)
	{
		writer.WriteLine($"{source.Name} misses {target.Name}");
	}


	public void AttackHit(Character source, Character target, int damageRoll)
	{
		writer.WriteLine($"{source.Name} hits {target.Name} for {damageRoll} damage");
	}
}