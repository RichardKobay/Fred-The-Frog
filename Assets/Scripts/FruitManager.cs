using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{

    public Text totalFruits;
    public Text collectedFruits;
    private int totalFruitsInt;

    private void Start()
    {
        totalFruitsInt = transform.childCount;
    }

    // Calls the AllFruitsCollected void every frame
    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInt.ToString();
        collectedFruits.text = transform.childCount.ToString();
    }

    // Detects if the total childs of fruitManager is 0
    public void AllFruitsCollected(){
        if(transform.childCount == 0){
            
        }
    }
}
