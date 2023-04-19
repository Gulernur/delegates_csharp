using System.Diagnostics.Tracing;

namespace CarEngine
{
    public delegate void EngineStartHandler();
    public delegate void EngineStopHandler();
    public delegate void EngineSpeedChangeHandler();

    public class CarEngine 
    { 
        public event EngineStartHandler EngineStarted; 
        public event EngineStopHandler EngineStopped; 
        public event EngineSpeedChangeHandler EngineSpeedChanged; 

        private bool isEngineRunning; 
        private int currentEngineSpeed; 

        public void StartEngine()
        {
            isEngineRunning = true; 
            EngineStarted.Invoke(); 
        }

    }
}
