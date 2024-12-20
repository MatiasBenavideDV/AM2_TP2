public class BulletPointer
{
    public static readonly BulletEntity CommonBullet = new BulletEntity
    {
        damage = 30f,
        ticks = 1,
        fireRate = 0.5f,
    };

    public static readonly BulletEntity IceBullet = new BulletEntity
    {
        damage = 40f,
        ticks = 5,
        fireRate = 1f
    };


    public static readonly BulletEntity FireBullet = new BulletEntity
    {
        damage = 20f,
        ticks = 3,
        fireRate = 0.15f
    };
}
