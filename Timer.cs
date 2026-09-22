using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Slider timerSlinder;
    [SerializeField] private float _maxtime = 120f;
    [SerializeField] private float _nowtime = 120f;
    [SerializeField] private float _extraTime = 10f;
    [SerializeField] private bool _isPlay = true;

    [SerializeField] private GameManager gameManager;
    void Start()
    {

    }


    void Update()
    {
        OnTimer();
    }

    // 시간 설정
    private void OnTimer()
    {
        if (!_isPlay)
        {
            return;
        }

        _nowtime -= Time.deltaTime;

        float _timeRatio = _nowtime / _maxtime;

        if (timerSlinder != null && _maxtime > 0)
        {
            timerSlinder.value = _timeRatio;
        }

        if (_timeRatio <= 0)
        {
            _isPlay = false;
            Debug.Log("시간 종료");

            if (gameManager != null)
            {
                gameManager.GameOver();
            }
        }

        
    }
    // 정답시 시간
    public void CorrectAnswer()
    {
        if (!_isPlay)
        {
            return;
        }
        _nowtime += _extraTime;

        if (_nowtime > _maxtime)
        {
            _nowtime = _maxtime;
        }

        Debug.Log($"정답 시간 추가 {_extraTime}");
    }

    // 오답시 시간
    public void IncorrectAnswer()
    {
        if (!_isPlay)
        {
            return;
        }
        _nowtime -= _extraTime;

        if (_nowtime <= 0)
        {
            _isPlay = false;

            Debug.Log($"시간 초과");

            if (gameManager != null)
            {
                gameManager.GameOver();
            }
        }

        Debug.Log($"정답 시간 감소 {_extraTime}");
    }




}



