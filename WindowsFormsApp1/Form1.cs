using System;
using System.Windows.Forms;

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
        }

        private int attackCounter = 0;

        private void btnAttackA_Click(object sender, EventArgs e)
        {
            attackCounter++;
            LogMessage($"=== Атака №{attackCounter }===");
            warriorA.StartAttack();
            LogMessage(""); 
        }

        private void btnAttackB_Click(object sender, EventArgs e)
        {
            attackCounter++;
            LogMessage($"=== Атака №{attackCounter} ===");
            warriorB.StartAttack();
            LogMessage(""); 
        }


        private void LogMessage(string message)
        {
            txtLog.AppendText(message + Environment.NewLine);
        }
    }

    public delegate void AttackEventHandler(Warrior sender);

    public class Warrior
    {
        public string Name { get; }

        private readonly Action<string> logger;

        public Warrior(string name, Action<string> logCallback)
        {
            Name = name;
            logger = logCallback;
        }

        public event AttackEventHandler Attack;
        public event AttackEventHandler CounterAttack;

        public void StartAttack()
        {
            logger($"{Name} починає атаку!");
            Attack?.Invoke(this);
        }

        public void StartCounterAttack()
        {
            logger($"{Name} виконує контратаку!");
            CounterAttack?.Invoke(this);
        }

        public void OnEnemyAttack(Warrior enemy)
        {
            logger($"{Name} реагує на атаку від {enemy.Name}.");
            StartCounterAttack();
        }

        public void OnEnemyCounterAttack(Warrior enemy)
        {
            logger($"{Name} отримав контратаку від {enemy.Name}.");
        }
    }
}
