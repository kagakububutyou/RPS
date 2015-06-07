using UnityEngine;
using System.Collections;
/// <summary>
/// キャラの手のインターフェイス
/// </summary>
public class ICharacterHand : MonoBehaviour {

    /// <summary>
    /// 手の種類
    /// </summary>
    public enum HandType
    {
        /// <summary>
        /// グー
        /// </summary>
        Rock,
        /// <summary>
        /// パー
        /// </summary>
        Paper,
        /// <summary>
        /// チョキ
        /// </summary>
        Sciccors,
        /// <summary>
        /// 最大
        /// </summary>
        MaxValue,
    };
    /// <summary>
    /// 手の種類
    /// </summary>
    public HandType handType = HandType.MaxValue;

    /// <summary>
    /// 手をもらってくる
    /// </summary>
    /// <param name="type">なんの手か</param>
    public void GetHand(HandType type)
    {
		handType = type;
    }
}
