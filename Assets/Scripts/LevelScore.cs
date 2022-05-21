using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : MonoBehaviour
{
    public Text levelScore;
    public static int levelScoreInt = 0;

    private void Update()
    {
        levelScore.text = levelScoreInt.ToString();
    }

    private void Start()
    {
        levelScoreInt = 0;
    }
}
