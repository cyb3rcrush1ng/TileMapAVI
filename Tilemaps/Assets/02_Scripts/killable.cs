using System;
using UnityEngine;

public class killable : MonoBehaviour
{
   private void OnCollisionStay2D(Collision2D collision)
   {
      if (collision.gameObject.tag == "Player")
         gameObject.SetActive(false);
   }
}