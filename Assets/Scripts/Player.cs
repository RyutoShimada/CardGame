using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] CardManager _cardManager = default;
    [SerializeField] int _firstDrawCard = default;
    [SerializeField] List<int> _holdCards = new List<int>();

    void Start()
    {
        for (int i = 0; i < _firstDrawCard; i++)
        {
            DrawCard();
        }
    }

    public void DrawCard()
    {
        if (!_cardManager.IsDeck) return;
        int card = _cardManager.DrawCard();

        if (card != 0)
        {
            _holdCards.Add(card);
            Debug.Log($"Draw card is { card }");
            Debug.Log($"The current number of cards is { _holdCards.Count }");
        }
    }

    public void UseCard()
    {
        if (_holdCards.Count <= 0)
        {
            Debug.Log("Not have cards");
            return;
        }

        int randam = Random.Range(0, _holdCards.Count);
        Debug.Log($"Use a card '{ _holdCards[randam] }'");
        _holdCards.RemoveAt(randam);
        Debug.Log($"The current number of cards is { _holdCards.Count }");
    }
}
