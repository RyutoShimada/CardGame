using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] int _minValue = default;
    [SerializeField] int _maxValue = default;
    [SerializeField] int _count = default;
    Dictionary<int, int> _deck = new Dictionary<int, int>();
    int _remainingDeck = default;
    bool _isDeck = default;

    public bool IsDeck { get => _isDeck; }

    private void Awake()
    {
        CreateCards();
    }

    void Start()
    {
        
    }

    void CreateCards()
    {
        int id = 0;

        for (int count = 0; count < _count; count++)
        {
            for (int i = _minValue; i <= _maxValue; i++)
            {
                if (i == 0) continue;
                _deck.Add(id, i);
                id++;
            }
        }

        _remainingDeck = _deck.Count;
        _isDeck = true;
    }

    public int DrawCard()
    {
        while (_remainingDeck > 0)
        {
            int random = Random.Range(0, _deck.Count);

            if (_deck[random] != 0)
            {
                int returnNumber = _deck[random];
                _deck[random] = 0;
                _remainingDeck--;
                return returnNumber;
            }
        }

        Debug.Log("NotDeck");
        _isDeck = false;
        return 0;
    }
}
