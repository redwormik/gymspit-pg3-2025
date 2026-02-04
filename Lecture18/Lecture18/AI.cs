namespace Lecture18;


public class AI : Controller
{
	private Random random;


	public AI(Random random)
	{
		this.random = random;
	}


	public string ChooseAction(Character character, Character enemy)
	{
		string[] choices = new string[] {
			Controller.TURN_CHOICE_ATTACK,
			Controller.TURN_CHOICE_ATTACK,
			Controller.TURN_CHOICE_WAIT,
		};

		return choices[this.random.Next(choices.Length)];
	}
}