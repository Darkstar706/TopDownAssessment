using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{
    public float levelTime = 100.0f;
    float timer = 0;
    public Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        TimeText.text = "Time: " + timer + "/100";
        timer += Time.deltaTime;
        if (timer > levelTime)
        {
            SceneManager.LoadScene(
                        SceneManager.GetActiveScene().name);
        }
    }
}
