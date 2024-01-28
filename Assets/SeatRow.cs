using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatRow : MonoBehaviour
{
    [SerializeField] private Transform _firstSeat;
    [SerializeField] private GameObject[] _peoplePrefabs;

    private List<GameObject> _people = new();

    private float _excitement = 0f;

    private void Update()
    {
        for (int i = 0; i < _people.Count; i++)
        {
            GameObject person = _people[i];
            Vector2 pos = person.transform.localPosition;
            pos.y = (Mathf.Sin((Time.time + i) * 10f * (_excitement + 1.1f)) + 1f) / 3f * (_excitement + 0.1f);
            person.transform.localPosition = pos;
        }
    }

    public void MakePeople(int row, int rowCount, float chance)
    {
        for (int i = 0; i < 23; i++)
        {
            if (Random.value < chance)
            {
                Vector2 position = new Vector2(_firstSeat.position.x + 0.9f * i, _firstSeat.position.y);
                GameObject person = Instantiate(_peoplePrefabs[Random.Range(0, _peoplePrefabs.Length)], position, Quaternion.identity, transform);
                SpriteRenderer sr = person.GetComponent<SpriteRenderer>();
                sr.sortingOrder = -500 + row;
                sr.color = Random.ColorHSV(0f, 1f, 0.3f, 0.3f, 0.4f, 0.4f);
                sr.color = Color.Lerp(Color.black, sr.color, (float)row / rowCount);
                _people.Add(person);
            }
        }
    }

    public void SetExcitementLevel(float level)
    {
        _excitement = level;
    }
}
