using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMaintainer : MonoBehaviour
{
    public static int score=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit"){
            score++;
            Debug.Log("Score = "+score.ToString());
        }
        
    }
}
