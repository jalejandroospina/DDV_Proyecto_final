using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;
    public int scoreInstance;

    public enum Rewards {AlienCoin , Jewel, Box};

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            scoreInstance = 0;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        PlayerController.OnDeath += GameOver;
    }

    public void GameOver()
    {
        scoreInstance = 0;
    }

    public void addScore()
    {
        instance.scoreInstance +=1;
    }
    public int GetScore()
    {
        return instance.scoreInstance;
    }
}
