using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIView : MonoBehaviour
{
    [SerializeField] private ScoreView _scoreView;
    [SerializeField] public GameObject SpawnPointObj;
    [SerializeField] public ResultView ResultView;


    private void Start()
    {
        GameController.Instance.Start();
        Time.timeScale = 0.5f;
    }
    

}
