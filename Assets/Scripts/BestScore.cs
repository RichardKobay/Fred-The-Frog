using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{

    public Text bestScore;

    // Start is called before the first frame update
    void Start()
    {
        bestScore.text = PlayerPrefs.GetInt("BestScore").ToString();
    }
}
