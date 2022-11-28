using UnityEngine;

public class MousePresenter : EnemyPresenter<Mouse>
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out PlayerPresenter player))
        {
            Model.Punch(player);
        }
    }
}
