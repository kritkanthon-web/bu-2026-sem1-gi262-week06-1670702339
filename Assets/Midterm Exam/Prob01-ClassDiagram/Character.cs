using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Character : GameEntity
    {
        public string characterName;
        protected float moveSpeed;
        private int level;

        public virtual void Attack(GameEntity target) { }
        protected virtual void LevelUp() { }
    }

}
