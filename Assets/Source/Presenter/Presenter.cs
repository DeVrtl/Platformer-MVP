using UnityEngine;
using Zenject;

public abstract class Presenter<TModel> : MonoBehaviour
	where TModel : class
{
	[Inject] public TModel Model { get; private set; }
	public bool IsSubscribed { get; private set; }

	protected bool TrySubscribeOnModel()
	{
		if (Model == null || IsSubscribed)
		{
			return false;
		}

		IsSubscribed = true;

		SubscribeOnModel();
		return true;
	}

	protected virtual void SubscribeOnModel() {}

	protected bool TryUnsubscribeOnModel()
	{
		if (Model == null || !IsSubscribed)
		{
			return false;
		}

		IsSubscribed = false;

		UnsubscribeFromModel();
		return true;
	}
		
	protected virtual void UnsubscribeFromModel() {}
}
