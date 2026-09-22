using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Hero : Character
    {
        public int currentExp;
        private int gold;

        public override void Attack(GameEntity target) { }
        public void CollectGold(int amount) { }
        protected override void LevelUp() { }
    }

}
