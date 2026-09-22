using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob03
{
    /// <summary>
    /// คลาส Player สำหรับจำลองตัวละครในเกมแนว Turn-based RPG
    /// มีความสามารถในการโจมตี (Attack) และใช้สกิลพิเศษสลับลำดับคิวการเล่น (SwapQueue)
    /// </summary>
    public class Player
    {
        public string Name;
        public int Health;

        public Player(string name, int health = 100)
        {
            Name = name;
            Health = health;
        }

        public void Attack(Player target)
        {
            if (target != null)
            {
                target.TakeDamage(10);
            }
        }

        public void TakeDamage(int damage)
        {
            Health = System.Math.Max(0, Health - damage);
        }

        public bool SwapQueue(
            LinkedList<Player> turnQueue,
            Player targetPlayer,
            Player afterPlayer)
        {
            if (turnQueue == null ||
                targetPlayer == null ||
                afterPlayer == null)
            {
                return false;
            }

            if (targetPlayer == afterPlayer)
            {
                return false;
            }

            LinkedListNode<Player> targetNode =
                turnQueue.Find(targetPlayer);

            LinkedListNode<Player> afterNode =
                turnQueue.Find(afterPlayer);

            if (targetNode == null || afterNode == null)
            {
                return false;
            }

            turnQueue.Remove(targetNode);
            turnQueue.AddAfter(afterNode, targetPlayer);

            return true;
        }

        public override string ToString()
        {
            return $"{Name} (HP: {Health})";
        }
    }
}