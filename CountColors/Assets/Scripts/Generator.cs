using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CountColors
{
    public class Generator : MonoBehaviour
    {
        const int ROWS = 5;
        const int COLUMNS = 11;
        const float CELL_SIZE = 1.5f;

        [SerializeField] GameObject[] figurePrefabs;

        int[,] figureMatrix;
        [SerializeField] float offset = 0.15f;

        void Start()
        {
            figureMatrix = new int[ROWS, COLUMNS];

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLUMNS; col++)
                {
                    figureMatrix[row, col] = Random.Range(0, 2);
                }
            }

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLUMNS; col++)
                {
                    bool _needCreate = Random.Range(0, 2) > 0;
                    if (_needCreate)
                    {
                        int _figureIndx = Random.Range(0, figurePrefabs.Length);
                        var _figureObj = Instantiate(figurePrefabs[_figureIndx], this.transform);

                        Vector3 _randomOffcet = new Vector3(Random.Range(-offset, offset), Random.Range(-offset, offset));
                        _figureObj.transform.position = new Vector3(CELL_SIZE * col, CELL_SIZE * row) + _randomOffcet + transform.position;
                    }
                }
            }
        }

        void Update()
        {

        }
    }
}
