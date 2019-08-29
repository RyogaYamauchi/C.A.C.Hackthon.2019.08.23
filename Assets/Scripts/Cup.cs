using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Cup: MonoBehaviour
    {
        public void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.GetComponent<Item>() == null) return;
            GameController.Instance.Score += other.gameObject.GetComponent<Item>().Kcal;
        }
    }
}