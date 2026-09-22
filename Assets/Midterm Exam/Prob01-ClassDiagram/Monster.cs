using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster : Character
    {
        public int baseDamage;
        protected int aggroRange;

        public override void Attack(GameEntity target) { }
        protected virtual void Roar() { }
    }
}
