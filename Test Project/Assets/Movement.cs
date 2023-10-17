using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public int speed, score;
    public float time;

    public Text scoreText, timeText;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += new Vector3(moveX, moveY, 0) * speed;

        time -= Time.deltaTime;
        timeText.text = "Time: " + time.ToString("0");
        scoreText.text = "Score: " + score.ToString("0");

        if (time <= 0f || Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
