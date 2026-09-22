using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Timer timer;
    [SerializeField] private GameObject effectImage;
   private void Awake()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }

        if (effectImage != null)
        {
            effectImage.SetActive(false);
        }
    }

    void Start()
    {

    }

   
    void Update()
    {
        
    }

   public void ClickButton()
    {
        Debug.Log("버튼 클릭");
        
        if (gameManager != null)
        {
            gameManager.FindNumver();
        }

        if (timer != null)
        {
            timer.CorrectAnswer();
        }

        if (effectImage != null)
        {
            effectImage.SetActive(true);
        }

        button.interactable = false;
    }
}
