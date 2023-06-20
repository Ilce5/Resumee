using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CryptoCoin")]
public class CryptoCoinSO : ScriptableObject {
 
 public string cryptoName;
 public string shortHandName;
 public float initialPrice;
 public float variance;
 
 
}
