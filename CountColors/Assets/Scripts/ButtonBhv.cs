using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CountColors
{
    public class ButtonBhv : MonoBehaviour
    {
        Button activeButton;
        int maxColorIndex;

        public int BtnColorIndex { get; set; }
        public bool IsRightColor { get; private set; }
        public bool IsWrongColor { get; private set; }

        void Start()
        {
            activeButton = GetComponent<Button>();
            activeButton.onClick.AddListener(CheckColor);
        }

        void CheckColor()
        {
            maxColorIndex = GameObject.FindObjectOfType<ColorCounter>().MaxAmountColorIndex;

            if (BtnColorIndex == maxColorIndex)
            {
                IsRightColor = true;
                IsWrongColor = false;
            }
            else
            {
                IsWrongColor = true;
                IsRightColor = false;
            }
        }
    }
}
