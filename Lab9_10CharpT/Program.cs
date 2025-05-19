//using System;

//namespace MilitaryActions
//{
//    public delegate void AttackEventHandler(Warrior sender);

//    public class Warrior
//    {
//        public string Name { get; }

//        public Warrior(string name)
//        {
//            Name = name;
//        }

//        public event AttackEventHandler Attack;
//        public event AttackEventHandler CounterAttack;

//        public void StartAttack()
//        {
//            Console.WriteLine($"{Name} починає атаку!");
//            Attack?.Invoke(this);
//        }

//        public void StartCounterAttack()
//        {
//            Console.WriteLine($"{Name} виконує контратаку!");
//            CounterAttack?.Invoke(this);
//        }

//        public void OnEnemyAttack(Warrior enemy)
//        {
//            Console.WriteLine($"{Name} реагує на атаку від {enemy.Name}.");
//            StartCounterAttack();
//        }

//        public void OnEnemyCounterAttack(Warrior enemy)
//        {
//            Console.WriteLine($"{Name} отримав контратаку від {enemy.Name}.");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = System.Text.Encoding.UTF8;

//            Warrior warriorA = new Warrior("Воїн A");
//            Warrior warriorB = new Warrior("Воїн B");

//            warriorA.Attack += warriorB.OnEnemyAttack;
//            warriorB.Attack += warriorA.OnEnemyAttack;

//            warriorA.CounterAttack += warriorB.OnEnemyCounterAttack;
//            warriorB.CounterAttack += warriorA.OnEnemyCounterAttack;

//            warriorA.StartAttack();

//            Console.ReadLine();
//        }
//    }
//}
