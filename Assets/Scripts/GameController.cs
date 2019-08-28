using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController
{
    
    [SerializeField] private UIView UIView;
    private GameObject SpawnPointObj => UIView.SpawnPointObj;
    public Vector3 SpawnPoint;
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
       // var SpawnPointwnPointObj = GameObject.Find("SpawnPoint").GetComponent<Transform>();
        SpawnPoint = SpawnPointObj.transform.position;
        Instance = new GameController();
    }

}
