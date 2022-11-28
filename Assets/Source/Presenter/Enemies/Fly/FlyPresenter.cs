using UnityEngine;

public class FlyPresenter : EnemyPresenter<Fly>
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out PlayerPresenter player))
        {
            Model.Punch(player);
        }
    }
}
