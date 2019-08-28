using System;
using UnityEditorInternal;
using UnityEngine;

namespace DefaultNamespace
{
    public class ChopStick : MonoBehaviour
    {
        public void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.GetComponent<Item>() == null) return;
            Debug.Log("アタッタ！！！！！！！！");
            
            /*if (other.gameObject.GetComponent<Item>().Type == "Tapioka")
            {
                GameController.Instance.Score += other.gameObject.GetComponent<Item>().Kcal;
            }*/
        }
    }
}