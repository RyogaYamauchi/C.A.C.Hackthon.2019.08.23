using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController
{
    
    public Vector3 SpawnPoint;
    [SerializeField] private UIView UIView;
    
    public int Time = 0;
    public int Score = 0;

    public static GameController Instance
    {
        get => _instance;
        set => _instance = value;
    }

    private static GameController _instance = new GameController();

    public void Start()
    {
        UIView = GameObject.Find("Canvas").GetComponent<UIView>();
        var SpawnPointObj = GameObject.Find("SpawnPoint").GetComponent<Transform>();
        SpawnPoint = SpawnPointObj.transform.position;
        Instance = new GameController();
        UIView.StartTime();
    }

}
