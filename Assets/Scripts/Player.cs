using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] CardManager _cardManager = default;

    void Start()
    {

    }

    public void DrawCard()
    {
        if (!_cardManager.IsDeck) return;
        int card = _cardManager.DrawCard();
        if (card != 0) Debug.Log(card);
    }
}
