using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isPurchased = false;

    [SerializeField] protected Bullet Bullet;

    public string Label => _label;
    public int Price => _price;
    public Sprite Icon => _icon;
    public bool IsPurchased => _isPurchased;

    public abstract IEnumerator Shoot(Transform shootPoint);

    public void Buy()
    {
        _isPurchased = true;
    }
}
