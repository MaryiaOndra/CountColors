using UnityEngine;

namespace CountColors 
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Figure : MonoBehaviour
    {
        SpriteRenderer figureSpriteRndr;
        Color[] colors;

        public Color FigureColor { get; private set; }

        void Start()
        {
            figureSpriteRndr = GetComponent<SpriteRenderer>();
            colors = new Color[] { Color.white, Color.red, Color.green, Color.blue};
            SetRandomColor();
        }

        void SetRandomColor()
        {
            int _colorIndx = Random.Range(0, colors.Length);
            figureSpriteRndr.color = colors[_colorIndx];
            FigureColor = figureSpriteRndr.color;
        }
    }
}
