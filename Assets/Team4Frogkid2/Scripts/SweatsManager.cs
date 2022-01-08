﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FROGKID2
{

    public class SweatsManager : MonoBehaviour
    {

        [SerializeField]
        List<Button> buttons;

        [SerializeField]
        private List<int> buttonSelector;

        private bool isFailed = false;


        // Start is called before the first frame update
        void Start()
        {

            MinigameManager.Instance.minigame.gameWin = false;
            int winId = Random.Range(0, buttons.Count);


            for (int i = 0; i < buttons.Count; i++)
            {
                if (i != winId)
                {
                    // select a sprite at random
                    if (buttonSelector.Count > 0)
                    {
                        int index = Random.Range(0, buttonSelector.Count);
                        int p = buttonSelector[index];
                        buttonSelector.RemoveAt(index);
                        buttons[i].SetButtonAnim(p);
                        Debug.Log(p);
                    }
                    else
                    {
                        // safety fallback
                        buttons[i].SetButtonAnim(0);
                    }
                }
                else
                {
                    buttons[i].SetButtonAnim(0);
                    buttons[winId].SetIsWin(true);
                }
            }


        }

        // Update is called once per frame
        void Update()
        {

        }

        public bool CheckCondition(bool isWin)
        {
            if (!isFailed && !MinigameManager.Instance.minigame.gameWin)
            {
                if (isWin)
                {
                    Win();
                }
                else
                {
                    Lose();
                }
                return true;
            }

            return false;
        }

        void Win()
        {
            Debug.Log("win");
            MinigameManager.Instance.minigame.gameWin = true;
        }

        void Lose()
        {
            isFailed = true;
            Debug.Log("lose");
        }
    }
}