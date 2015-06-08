using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateCircle : MonoBehaviour {

    [SerializeField]
    private Image image = null;
    [SerializeField]
    private float countMax = 0.0f;

    [SerializeField]
    private Color32 color = new Color32(0, 0, 0, 0);

    private float fadeAlpha = 1.0f;

	// Use this for initialization
	private void Start () 
    {
        // タッチしたときのスクリーン座標を取得
        Vector2 screenPos = Input.mousePosition;
        image.transform.position = screenPos;
        StartCoroutine(CountDown(countMax));
	}
	
	// Update is called once per frame
	private void Update ()
    {
        DrawCircle();
	}

    private IEnumerator CountDown(float interval)
    {
        float time = 0;
        while (time <= interval)
        {
            fadeAlpha = Mathf.Lerp(1.0f, 0.0f, time / interval);
            time += Time.deltaTime;
            yield return 0;
            Debug.Log(fadeAlpha);
        }
    }

    private void DrawCircle()
    {
        image.color = new Vector4(color.r, color.g, color.b, fadeAlpha);
        if(fadeAlpha < 0.1)
        {
            image.enabled = false;
        }
    }
}
