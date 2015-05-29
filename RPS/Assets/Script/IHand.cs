using UnityEngine;
using System.Collections;

public class IHand : MonoBehaviour {

    [SerializeField]
    protected ICharacterHand manager = null;

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
