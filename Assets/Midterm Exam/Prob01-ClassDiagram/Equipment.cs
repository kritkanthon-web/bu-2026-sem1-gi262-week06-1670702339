using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Equipment : InventoryItem
    {
        public int durability;
        protected bool isEquipped;

        public virtual void Equip(Hero hero) { }
        public override void Use(Character user) { }
    }
}
