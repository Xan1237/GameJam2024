using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private GameObject _rowPrefab;
    [SerializeField] private int _rowCount;

    private List<SeatRow> _rows = new();

    public void GenerateBackground()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < _rowCount; j++)
            {
                GameObject row = Instantiate(_rowPrefab, transform);

                float x = (j * 0.35f * ((i * 2) - 1)) + (i * 35f) + (j % 2 == 0 ? 0 : 0.8f) - 24f;
                float y = 10f + j * -1.25f;

                row.transform.localPosition = new Vector2(x, y);
                SpriteRenderer sr = row.GetComponent<SpriteRenderer>();
                sr.color = Color.Lerp(Color.black, Color.white, (float)j / _rowCount);
                sr.sortingOrder = -501 + j;
                row.GetComponent<SeatRow>().MakePeople(j, _rowCount, 0.5f);
                _rows.Add(row.GetComponent<SeatRow>());
            }
        }
    }

    public void SetExcitementLevel(float level)
    {
        foreach (var row in _rows)
        {
            row.SetExcitementLevel(level);
        }
    }
}
