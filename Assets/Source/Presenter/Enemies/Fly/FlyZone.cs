using UnityEngine;

public class FlyZone : MonoBehaviour
{
    public Transform Target { get; private set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out PlayerPresenter player))
        {
            Target = player.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out PlayerPresenter player))
        {
            Target = null;
        }
    }
}
