using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverText;
    [SerializeField] private Player _player;
    [SerializeField] private float _maxGameTime = 30.0f;
    [SerializeField] private TMP_Text _timerDisplay;
    [SerializeField] private Timer _gameTimer;

    // STEP 8 -----------------------------------------------------------------
    // Start runs ONCE, when the GAME BEGINS. It is called by Unity.
    private void Start()
    {
        // Start the game timer with _maxGameTime seconds.
        _gameTimer.BeginTimer(_maxGameTime);
    }
    // STEP 8 -----------------------------------------------------------------

    // ------------------------------------------------------------------------
    private void Update()
    {
        // STEP 9 -------------------------------------------------------------
        // Every frame, check if the game timer ran out. If it did, call GameOver.
        if (_gameTimer.IsFinished())
        {
            GameOver();
        }
        // STEP 9 -------------------------------------------------------------

        _timerDisplay.text = _gameTimer.GetTimeLeft().ToString();
    }

    // ------------------------------------------------------------------------
    private void GameOver ()
    {
        _player.SetGameOver();
        _gameOverText.SetActive(true);
    }
}