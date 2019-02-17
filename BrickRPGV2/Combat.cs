
namespace BrickRPGV2
{
    interface Melee
    {
        int attack(Entity e);
        void drainMana(Entity e);
        bool hitOrMiss(Entity e);
    }

    interface Ranged
    {
        int defend(Entity e);
        bool blockChance(Entity e);
        void breakDown();
    }
}