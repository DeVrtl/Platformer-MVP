using UnityEngine;

public class ApplicationLoader : MonoBehaviour
{
    private void Awake()
    {
        GameServicesContainer.Init();
    }
}
