using UnityEngine;

public class Timer : MonoBehaviour
{
    // STEP 1 -----------------------------------------------------------------
    // A member variable that keeps track of how much time we have left.
    // [SerializeField] lets us see and tune it in the Inspector.

    [SerializeField] private float _timeLeft;

    // STEP 1 -----------------------------------------------------------------

    // STEP 2 -----------------------------------------------------------------
    // This method starts the timer's countdown.
    // Input: the amount of time the countdown should start with.
    // Output: none (void).
    public void BeginTimer(float startTime)
    {
        // Set our timer member variable to the countdown start time parameter.
        _timeLeft = startTime;
    }

    // STEP 2 -----------------------------------------------------------------

    // STEP 3 -----------------------------------------------------------------
    // Update is a built-in Unity method that runs EVERY FRAME.
    // Every frame, subtract the time that has passed since the last frame.
        private void Update()
    {
        _timeLeft = _timeLeft - Time.deltaTime;
    }

    // STEP 3 -----------------------------------------------------------------

    // This method can be used to check the value of your time member variable.
    public float GetTimeLeft()
    {
        // STEP 4 -------------------------------------------------------------
        return _timeLeft;
        // STEP 4 -------------------------------------------------------------
    }

    // STEP 5 -----------------------------------------------------------------
    // Returns true if our time member variable is out of time.
    public bool IsFinished()
    {
        return _timeLeft <= 0;
    }

    // STEP 5 -----------------------------------------------------------------
}