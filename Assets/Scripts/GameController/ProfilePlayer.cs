namespace StayFast
{
    public class ProfilePlayer
    {
        public SubscriptionProperty<GameState> CurrentState { get; }

        public ProfilePlayer()
        {
            CurrentState = new SubscriptionProperty<GameState>() { Value = GameState.None};
        }
    }

    public enum GameState
    {
        None,
        Loading,
        Game,
        ChangeDays,
        End
    }
}