using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    public int TotalCoin = 0;
    public Rigidbody rd;
    public float speed = 5;
    public float movementSpeed;
    public GameObject GameOverPanel;
    bool IsGameOver = false;
    private float initilizePositionZ = 2252f;
    public RoadManager roadManager;

    [Header("Stat Texts")]
    public TMP_Text ScoreText;
    public TMP_Text HighScoreText;
    public TMP_Text SpeedText;
    public TMP_Text CoinText;

    public List<Color> colors;
    public Material _mat;
    private void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, initilizePositionZ);
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        HighScoreText.text = "HighScore: " + currentHighScore.ToString();
        int previousCoins = PlayerPrefs.GetInt("Coins", 0);
        PlayerPrefs.SetInt("Coins", previousCoins);
        CoinText.text = "Coins: " + previousCoins.ToString();
        _mat.EnableKeyword("_Emission");
        int activecolorindex = PlayerPrefs.GetInt("ActiveColorIndex", 0);
        if(activecolorindex < colors.Count)
        {
            Color color = colors[activecolorindex];
            color *= 40;
            _mat.SetColor("_EmissionColor", color);
        }
        else
        {
            Debug.LogWarning("Active color index out of range. Using default color.");
            Color defaultColor = colors[0];
            defaultColor*= 40;
            _mat.SetColor("_EmissionColor", defaultColor);
        }
        
    }
    void Update()
    {
        if (!IsGameOver)
        {
            movementHandler();
        }
        scoreHandler();
        updateSpeed();
    }
    void updateSpeed()
    {
        SpeedText.text = "Speed: " + rd.angularVelocity.magnitude.ToString("##") + "KM/H";
    }
    private void movementHandler()
    {
        rd.AddForce(Vector3.forward * speed);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (transform.position.x < -5 || transform.position.x > 5)
        {
            GameOver();
        }
    }

    public void MoveLeft()
    {
        rd.AddForce(Vector3.left * movementSpeed);
    }
    public void MoveRight()
    {
        rd.AddForce(Vector3.right * movementSpeed);
    }
    private void scoreHandler()
    {
        float score = transform.position.z - initilizePositionZ;
        ScoreText.text = "Score: " + score.ToString("##");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            GameOver();
            AudioHandler.instance.PlayOnObstacleHit();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RoadEndPoint")
        {
            roadManager.SpawnARoad();
        }
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            CoinCollide();
        }
    }
    public void CoinCollide()
    {
        TotalCoin++;
        int previousCoins = PlayerPrefs.GetInt("Coins", 0);
        previousCoins += 1;
        PlayerPrefs.SetInt("Coins", previousCoins);
        CoinText.text = "Coins: " + previousCoins.ToString();
        AudioHandler.instance.PlayCoinCollectSound();
    }
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        IsGameOver = true;
        CalcHighScore();
    }

    void CalcHighScore()
    {
        int currentScore = (int)(transform.position.z - initilizePositionZ);
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (currentScore > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
        }
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}