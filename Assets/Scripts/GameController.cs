using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private TimeView _timeView;
    [SerializeField] private ScoreView _scoreView;
    [SerializeField] private Transform SpawnPoint;

    public List<GameObject> PlayerHoldingItems = new List<GameObject>();

    public int Time = 0;
    public int Score = 0;
    
    void Start()
    {
        StartCoroutine(CountDownTime());
    }

    public IEnumerator CountDownTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Time++;
            Updatetime();
            if (Time % 5 ==0)
            {
                SpawnTapioka();
            }
        }
    }

    private void SpawnTapioka()
    {
        var obj = Resources.LoadAsync("Tapioka");
        var instance = (GameObject) Instantiate(obj.asset, SpawnPoint.position, Quaternion.identity);
    }

    private void AdditionalScore(int score)
    {
        Score += score;
        UpdateScore();
    }

    private void UpdateScore()
    {
        _scoreView.SetScoreText(Score.ToString());
    }

    private void Updatetime()
    {
        _timeView.Updatetime(Time);
    }
        
}
