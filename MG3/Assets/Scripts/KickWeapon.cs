using UnityEngine;

public class KickWeapon : MonoBehaviour
{
    [SerializeField] private float _lifetimeSeconds;
    [SerializeField] private Timer _lifeTimer;

    // ------------------------------------------------------------------------
    public void ActivateKick()
    {
        gameObject.SetActive(true);

        // STEP 6 -------------------------------------------------------------
        // Start our timer with the number of seconds _lifetimeSeconds is set to.
        _lifeTimer.BeginTimer(_lifetimeSeconds);
        // STEP 6 -------------------------------------------------------------
    }

    // STEP 7 -----------------------------------------------------------------
    // Update is a built-in Unity method that runs EVERY FRAME.
    // Every frame, check if the timer has run out, and disable the kick when done.
    private void Update()
    {
        if (_lifeTimer.IsFinished())
        {
            gameObject.SetActive(false);
        }
    }
    // STEP 7 -----------------------------------------------------------------
}