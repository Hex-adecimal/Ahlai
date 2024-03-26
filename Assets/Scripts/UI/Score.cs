using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float score;

    public Text highScore;

    // Start is called before the first frame update
    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString() ;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null ) 
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }

        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", (int)score); 
            highScore.text = score.ToString("0");
        }
    }
}
