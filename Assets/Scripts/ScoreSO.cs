using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ScoreSO : ScriptableObject
{
   [SerializeField] public int _score;
   

   public int score
   {
      get { return _score; }
      set { _score = score; }
   }
}
