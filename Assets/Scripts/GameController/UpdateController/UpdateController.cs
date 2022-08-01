using System.Collections.Generic;

namespace StayFast
{
    public class UpdateController : IInitialization, IExecute, ILateExecute, ICleanup
    {
        private readonly List<IInitialization> _initializeControllers;
        private readonly List<IExecute> _executeController;
        private readonly List<ILateExecute> _lateExecutes;
        private readonly List<ICleanup> _cleanups;
        

        public UpdateController()
        {
            _initializeControllers = new List<IInitialization>();
            _executeController = new List<IExecute>();
            _lateExecutes = new List<ILateExecute>();
            _cleanups = new List<ICleanup>();
        }

        internal UpdateController Add(IController controller)
        {
            if (controller is IInitialization initializeController)
            {
                _initializeControllers.Add(initializeController);
            }

            if (controller is IExecute execute)
            {
                _executeController.Add(execute);
            }

            if (controller is ILateExecute lateExecute)
            {
                _lateExecutes.Add(lateExecute);
            }

            if (controller is ICleanup cleanup)
            {
                _cleanups.Add(cleanup);
            }

            return this;
        }
        
        public void Initialization()
        {
            for (int index = 0; index < _initializeControllers.Count; index++)
            {
                _initializeControllers[index]?.Initialization();
            }
        }
        
        public void Execute(float deltaTime)
        {
            for (int index = 0; index < _executeController.Count; index++)
            {
                _executeController[index]?.Execute(deltaTime);
            }
        }


        public void LateExecute(float deltaTime)
        {
            if (_lateExecutes.Count > 0)
            {
                for (int index = 0; index < _lateExecutes.Count; index++)
                {
                    _lateExecutes[index]?.LateExecute(deltaTime);
                }
            }
            
        }
        
        public void Cleanup()
        {
            for (int index = 0; index < _cleanups.Count; index++)
            {
                _cleanups[index]?.Cleanup();
            }
        }
    }
}