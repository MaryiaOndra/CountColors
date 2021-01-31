using UnityEngine;

namespace CountColors
{
    public class ColorCounter : MonoBehaviour
    {
        Figure[] generatedFigures;

        int[] colorAmountsArray;
        int redAmount;
        int yellowAmount;
        int blueAmount;
        int greenAmount;

        public int MaxAmountColorIndex { get; private set; }
                
        void Start()
        {
            generatedFigures = GetComponent<Generator>().GeneratedFigures;
            CountColorAmount();
            FindMaxColorAmount();
        }

        void CountColorAmount() 
        {
            foreach (var figure in generatedFigures)
            {
                int _colorInt = figure.ActiveColorInt;

                if (_colorInt.Equals((int)FigureColor.Red))
                {
                    redAmount++;
                }
                else if (_colorInt.Equals((int)FigureColor.Green))
                {
                    greenAmount++;
                }
                else if (_colorInt.Equals((int)FigureColor.Blue)) 
                {
                    blueAmount++;
                }
                else if (_colorInt.Equals((int)FigureColor.Yellow))
                {
                    yellowAmount++;
                }
            }
        }

        void FindMaxColorAmount() 
        {
            int _maxValueIndex;
            int _maxValue = 0;
            colorAmountsArray = new int[] { redAmount, yellowAmount, blueAmount, greenAmount };

            for (int i = 0; i < colorAmountsArray.Length; i++)
            {
                if (colorAmountsArray[i] > _maxValue)
                {
                    _maxValue = colorAmountsArray[i];
                    _maxValueIndex = i;
                }
            }

            foreach (var amount in colorAmountsArray)
            {
                if (_maxValue.Equals(redAmount))
                {
                    MaxAmountColorIndex = (int)FigureColor.Red;
                }
                else if (_maxValue.Equals(yellowAmount))
                {
                    MaxAmountColorIndex = (int)FigureColor.Yellow;
                }
                else if (_maxValue.Equals(blueAmount))
                {
                    MaxAmountColorIndex = (int)FigureColor.Blue;
                }
                else if (_maxValue.Equals(greenAmount))
                {
                    MaxAmountColorIndex = (int)FigureColor.Green;
                }
            }
        }
    }
}
