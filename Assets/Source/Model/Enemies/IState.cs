public interface IState<TContext>
	where TContext : class
{
	void EnterState();
	void UpdateState();
}
