namespace StayFast
{
    public interface ILateExecute : IController
    {
        void LateExecute(float deltaTime);
    }
}