using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MilitaryActionsGUI
{
    public partial class Form1 : Form
    {
        private Warrior warriorA;
        private Warrior warriorB;

        public Form1()
        {
            InitializeComponent();

            warriorA = new Warrior("Воїн A", LogMessage);
            warriorB = new Warrior("Воїн B", LogMessage);

            warriorA.Attack += warriorB.OnEnemyAttack;
            warriorB.Attack += warriorA.OnEnemyAttack;

            warriorA.CounterAttack += warriorB.OnEnemyCounterAttack;
            warriorB.CounterAttack += warriorA.OnEnemyCounterAttack;

            UpdateHealthBars();
        }

        private int attackCounter = 0;

        private void btnAttackA_Click(object sender, EventArgs e)
        {
            if (warriorA.IsDead || warriorB.IsDead)
            {
                LogMessage("Бій завершено, один з воїнів вже повалений.");
                return;
            }

            attackCounter++;
            LogMessage($"=== Атака №{attackCounter} ===");
            warriorA.StartAttack();
            LogMessage("");
            UpdateHealthBars();
        }

        private void btnAttackB_Click(object sender, EventArgs e)
        {
            if (warriorA.IsDead || warriorB.IsDead)
            {
                LogMessage("Бій завершено, один з воїнів вже повалений.");
                return;
            }

            attackCounter++;
            LogMessage($"=== Атака №{attackCounter} ===");
            warriorB.StartAttack();
            LogMessage("");
            UpdateHealthBars();
        }


        private void LogMessage(string message)
        {
            txtLog.AppendText(message + Environment.NewLine);
        }

        private void UpdateHealthBars()
        {
            progressBarA.Value = warriorA.Health > 0 ? warriorA.Health : 0;
            progressBarB.Value = warriorB.Health > 0 ? warriorB.Health : 0;

            lblHealthA.Text = $"{warriorA.Name} Здоров'я: {progressBarA.Value}";
            lblHealthB.Text = $"{warriorB.Name} Здоров'я: {progressBarB.Value}";
        }
    }

    public delegate void AttackEventHandler(Warrior sender);

    public class Warrior
    {
        private static Random rng = new Random();

        public string Name { get; }
        private readonly Action<string> logger;

        public int Health { get; private set; } = 100;
        private int counterAttackLimit = 1;
        public bool IsDead => Health <= 0;

        public Warrior(string name, Action<string> logCallback)
        {
            Name = name;
            logger = logCallback;
        }

        public event AttackEventHandler Attack;
        public event AttackEventHandler CounterAttack;

        public void StartAttack()
        {
            if (IsDead)
            {
                logger($"{Name} вже повалений і не може атакувати.");
                return;
            }

            logger($"{Name} починає атаку!");
            Attack?.Invoke(this);
        }

        public void StartCounterAttack()
        {
            if (IsDead)
            {
                logger($"{Name} вже повалений і не може контратакувати.");
                return;
            }

            if (counterAttackLimit <= 0)
            {
                logger($"{Name} не може контратакувати більше одного разу в одній атаці.");
                return;
            }

            counterAttackLimit--;
            logger($"{Name} виконує контратаку!");
            CounterAttack?.Invoke(this);
            counterAttackLimit = 1;
        }

        private int CalculateDamage(int minDamage, int maxDamage)
        {
            int damage = rng.Next(minDamage, maxDamage + 1);

            // Критичний удар 15%
            bool isCritical = rng.Next(100) < 15;
            if (isCritical)
            {
                damage *= 2;
                logger($"{Name} наносить критичний удар! Урон подвоєний.");
            }

            return damage;
        }

        private bool TryBlock()
        {
            // Блок 20%
            bool blocked = rng.Next(100) < 20;
            if (blocked)
            {
                logger($"{Name} блокує частину урону!");
            }
            return blocked;
        }

        public void OnEnemyAttack(Warrior enemy)
        {
            if (IsDead) return;

            int baseDamage = CalculateDamage(8, 15);

            // Перевірка блокування
            bool blocked = TryBlock();
            int finalDamage = blocked ? baseDamage / 2 : baseDamage;

            Health -= finalDamage;

            logger($"{Name} отримує атаку від {enemy.Name} на {finalDamage} урону. Здоров'я: {Health}");

            if (IsDead)
            {
                logger($"{Name} повалений у бою!");
                return;
            }

            StartCounterAttack();
        }

        public void OnEnemyCounterAttack(Warrior enemy)
        {
            if (IsDead) return;

            int baseDamage = CalculateDamage(4, 8);
            bool blocked = TryBlock();
            int finalDamage = blocked ? baseDamage / 2 : baseDamage;

            Health -= finalDamage;

            logger($"{Name} отримує контратаку від {enemy.Name} на {finalDamage} урону. Здоров'я: {Health}");

            if (IsDead)
            {
                logger($"{Name} повалений у бою!");
            }
        }
    }
}
