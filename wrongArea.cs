    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    public class wrongArea : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private GameManager gameManager;
        [SerializeField] private Timer timer;
        private void Awake()
        {
            if (button == null)
            {
                button = GetComponent<Button>();
            }
        }
  
        public void WrongClickButton()
        {
            Debug.Log("버튼 클릭");

            if (timer != null)
            {
                timer.IncorrectAnswer();

            }
        }

    }
