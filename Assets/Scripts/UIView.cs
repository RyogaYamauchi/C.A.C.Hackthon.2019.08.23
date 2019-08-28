using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIView : MonoBehaviour
{
    [SerializeField] private ScoreView _scoreView;
    [SerializeField] public GameObject SpawnPointObj;


    private void Start()
    {
        GameController.Instance.Start();
        Time.timeScale = 0.5f;
    }
   
    
    public void UpdateScore()
    {
        _scoreView.SetScoreText(GameController.Instance.Score.ToString());
    }

   
   
    private void AdditionalScore(int score)
    {
        GameController.Instance.Score += score;
        UpdateScore();
    }
    
}
