using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UIView : MonoBehaviour
{
    [SerializeField] private TimeView _timeView;
    [SerializeField] private ScoreView _scoreView;

    private void Start()
    {
        GameController.Instance.Start();
    }
    public void StartTime()
    {
        StartCoroutine(CountDownTime());
    }
    
    public void UpdateScore()
    {
        _scoreView.SetScoreText(GameController.Instance.Score.ToString());
    }

    public void Updatetime()
    {
        _timeView.Updatetime(GameController.Instance.Time);
    }
    public IEnumerator CountDownTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            GameController.Instance.Time++;
            Updatetime();
            if (GameController.Instance.Time % 5 ==0)
            {
                StartCoroutine(SpawnTapioka());
            }
        }
    }
    private void AdditionalScore(int score)
    {
        GameController.Instance.Score += score;
        UpdateScore();
    }
    private IEnumerator SpawnTapioka()
    {
        var obj = Resources.LoadAsync("Tapioka");
        yield return obj;
        var instance = (GameObject) Instantiate(obj.asset,
            new Vector3(0,8.65f,-7.7f), Quaternion.identity);
    }
}
