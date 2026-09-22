using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _maxNumber = 5;
    [SerializeField] private int _nowNumber = 0;
    [SerializeField] private Text scoreTextUI;
    [SerializeField] private GameObject clearImage;
    [SerializeField] private GameObject gameOverImage;
    private void Start()
    {
        ScoreText();
        if (clearImage != null )
        {
            clearImage.SetActive(false);
        }
        if (clearImage != null)
        {
            clearImage.SetActive(false);
        }
        if (gameOverImage != null)
        {
            gameOverImage.SetActive(false);
        }
    }

    public void FindNumver()
    {
        _nowNumber++;
        Debug.Log($" {_nowNumber} / {_maxNumber}");

        ScoreText();

        if (_nowNumber >= _maxNumber)
        {
            Debug.Log("클리어");
            ClearImage();
  
        }

    }

    private void ScoreText()
    {
        if (scoreTextUI != null)
        {
            scoreTextUI.text = $" {_nowNumber} / {_maxNumber}";
        }
    }

    private void ClearImage()
    {
        if (clearImage != null)
        {
            clearImage.SetActive(true);
        }

    }

    public void GameOver()
    {
        if (gameOverImage != null)
        {
            gameOverImage.SetActive(true);
        }
    }

    public void NextScene()
    {
        string nowSceneName = SceneManager.GetActiveScene().name;

        if (nowSceneName == "Stage2")
        {

        }

        else
        {
            SceneManager.LoadScene("Stage2");

            Debug.Log("다음 스테이지");
        }
    }

    public void ReStart()
    {
        string nowSceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene(nowSceneName);

        Debug.Log("재시작");

    }
}
