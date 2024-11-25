using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour, IntItem
{
   public static event Action<int> OnGemCollect;
   public int worth = 1;

   public void Collect()
   {
      OnGemCollect.Invoke(worth);
      Destroy(gameObject);
   }
}
