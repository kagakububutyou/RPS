using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
/// <summary>
/// 相手の手を決めるスクリプト
/// </summary>
public class EnemyHand : IHand{

    [System.Serializable]
    public struct DATA
    {
        public DATA(ICharacterHand.HandType type, Sprite sprite)
        {
            this.type = type;
            this.sprite = sprite;
 
        }
        public ICharacterHand.HandType type;
        public Sprite sprite;
    }


    [SerializeField]
    List<DATA> data = new List<DATA>();

    Image image = null;

    /// <summary>
    /// 初期化のためにこれを使用してください
    /// </summary>
    private void Start()
    {
        image = GetComponent<Image>();
        PushHand();
    }
    /// <summary>
    /// カウントダウンがゼロになったら呼ぶ
    /// </summary>
    public void ChangeDrawMode(bool Mode)
    {

    }
    
    private void RandomHand()
    {
        handType = (ICharacterHand.HandType)Random.Range(0, (int)ICharacterHand.HandType.MaxValue);
        foreach (var d in data)
	    {
            if (d.type == handType)
            {
		        image.sprite = d.sprite;
                break;
            }
	    }
    }

    /// <summary>
    /// 何を出すか決めるところ
    /// </summary>
    protected override void PushHand()
    {
        RandomHand();
        manager.GetHand(handType);
    }
}
