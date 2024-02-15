using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour {
    //TODO:
    [SerializeField] TMP_Text scoreLabel;
    [SerializeField] TMP_Text bananamanscoreLabel;
    [SerializeField] TMP_Text capsulescoreLabel;
    [SerializeField] SettingsPopup settingsPopup;

    private int _score;
    private int _score2;
    private int _score1;

    void Start()
    {
        _score = 0;
        _score1 = 0;
        _score2 = 0;
        scoreLabel.text = _score.ToString();

        bananamanscoreLabel.text = _score1.ToString();

        capsulescoreLabel.text = _score2.ToString();

        settingsPopup.Close();
    }

    private void OnEnable()
    {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
        Messenger.AddListener(GameEvent.BANANAMAN_HIT, OnBananaManHit);
        Messenger.AddListener(GameEvent.CAPSULE_HIT, OnCapsuleHit);
    }

    void OnDisable()
    {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
        Messenger.RemoveListener(GameEvent.BANANAMAN_HIT, OnBananaManHit);
        Messenger.RemoveListener(GameEvent.CAPSULE_HIT, OnCapsuleHit);
    }   

    public void OnOpenSettings()
    {
        settingsPopup.Open();
    }
    public void OnEnemyHit()
    {
        _score += 1;
        scoreLabel.text = _score.ToString();
    }
    public void OnBananaManHit()
   {
        _score1 += 10;
        bananamanscoreLabel.text = _score1.ToString();
    }

    public void OnCapsuleHit()
    {
        _score2 += 5;
        capsulescoreLabel.text = _score2.ToString();
    }
}
