using UnityEngine;
using System.Collections;
/// <summary>
/// 手のインターフェイス
/// </summary>
public class IHand : MonoBehaviour {

    /// <summary>
    /// マネージャー
    /// </summary>
    [SerializeField]
    protected ICharacterHand manager = null;

    /// <summary>
    /// 手の種類
    /// </summary>
    [SerializeField]
    protected ICharacterHand.HandType handType = ICharacterHand.HandType.MaxValue;


    /// <summary>
    /// なんのボタンが押されたか
    /// </summary>
    virtual protected void PushHand()
    {
        manager.GetHand(handType);
    }
}
