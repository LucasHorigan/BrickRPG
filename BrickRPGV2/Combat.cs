using Characters;
namespace BrickRPGV2
{
    interface Weapon
    {
        int attack(Entity e);
        void drainMana(Entity e);
        bool hitOrMiss(Entity e);
    }
    interface Shield
    {
        int defend(Entity e);
        bool blockChance(Entity e);
        void breakDown();
    }
}