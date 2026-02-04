namespace Lecture18;


public class Character
{
	private Controller controller;

	private string name;

	private int hitPoints;

	private int maxHitPoints;

	private int attackBonus;

	private int armorClass;

	private Die weaponDie;


	public Character(Controller controller, string name, int maxHitPoints, int attackBonus, int armorClass, Die weponDie)
	{
		this.controller = controller;
		this.name = name;
		this.maxHitPoints = maxHitPoints;
		this.attackBonus = attackBonus;
		this.armorClass = armorClass;
		this.weaponDie = weponDie;
		Reset();
	}

	public Controller Controller => controller;

	public string Name => name;

	public double HealthRatio => (double) hitPoints / maxHitPoints;

	public bool Alive => hitPoints > 0;


	public void Reset()
	{
		hitPoints = maxHitPoints;
	}


	public void Attack(Log log, Character target, Die attackDie)
	{
		int attackRoll = RollAttack(attackDie);
		log.CharacterAttack(this, target, attackRoll);
		target.Hit(log, this, attackRoll);
	}


	public void Hit(Log log, Character source, int attackRoll)
	{
		if (attackRoll < armorClass) {
			log.AttackMiss(source, this);
			return;
		}

		int damageRoll = source.RollDamage();
		log.AttackHit(source, this, damageRoll);
		hitPoints -= damageRoll;
	}


	public void Wait(Log log, Die waitDie)
	{
		log.CharacterWait(this, waitDie.Roll());
	}


	public int RollAttack(Die attackDie)
	{
		return attackDie.Roll() + attackBonus;
	}


	public int RollDamage()
	{
		return weaponDie.Roll() + attackBonus;
	}
}
