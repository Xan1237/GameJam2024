using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private GameObject _rowPrefab;
    [SerializeField] private int _rowCount;

    private void Start()
    {
        GenerateBackground();
    }

    private void GenerateBackground()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < _rowCount; j++)
            {
                GameObject row = Instantiate(_rowPrefab, transform);

                float x = (i * 25f) + (j % 2 == 0 ? 0 : 0.8f) - 20f;
                float y = 10f + j * -1.25f;

                row.transform.localPosition = new Vector2(x, y);
                row.GetComponent<SpriteRenderer>().color = Color.Lerp(Color.black, Color.white, (float)j / _rowCount);
            }
        }
    }
}
