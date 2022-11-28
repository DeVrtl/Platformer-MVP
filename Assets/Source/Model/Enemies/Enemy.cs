public class Enemy
{
    private const float Damage = 1;

    public void Punch(Presenter<Player> player)
    {
        player.Model.TakeDamage(Damage);
    }
}
