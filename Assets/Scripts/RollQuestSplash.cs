using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class RollQuestSplash : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Bootstrap()
    {
        GameObject obj = new GameObject("RollQuestSplash");
        DontDestroyOnLoad(obj);
        obj.AddComponent<RollQuestSplash>();
    }

    private void Start()
    {
        StartCoroutine(ShowSplash());
    }

    private IEnumerator ShowSplash()
    {
        AsyncOperation load = SceneManager.LoadSceneAsync(0);
        load.allowSceneActivation = false;

        GameObject canvasObject = new GameObject("RollQuestSplashCanvas");
        Canvas canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 9999;

        CanvasScaler scaler = canvasObject.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1080, 1920);

        canvasObject.AddComponent<GraphicRaycaster>();

        GameObject background = new GameObject("Background");
        background.transform.SetParent(canvasObject.transform, false);

        Image bg = background.AddComponent<Image>();
        bg.color = Color.black;

        RectTransform bgRect = background.GetComponent<RectTransform>();
        bgRect.anchorMin = Vector2.zero;
        bgRect.anchorMax = Vector2.one;
        bgRect.offsetMin = Vector2.zero;
        bgRect.offsetMax = Vector2.zero;

        Sprite logoSprite = Resources.Load<Sprite>("Splash/RollQuestSplash");

        if (logoSprite != null)
        {
            GameObject logo = new GameObject("RollQuestLogo");
            logo.transform.SetParent(canvasObject.transform, false);

            Image logoImage = logo.AddComponent<Image>();
            logoImage.sprite = logoSprite;
            logoImage.preserveAspect = true;

            RectTransform logoRect = logo.GetComponent<RectTransform>();
            logoRect.anchorMin = new Vector2(0.5f, 0.55f);
            logoRect.anchorMax = new Vector2(0.5f, 0.55f);
            logoRect.sizeDelta = new Vector2(800, 500);
            logoRect.anchoredPosition = Vector2.zero;
        }

        GameObject barObject = new GameObject("LoadingBar");
        barObject.transform.SetParent(canvasObject.transform, false);

        Image bar = barObject.AddComponent<Image>();
        bar.color = new Color(1f, 1f, 1f, 0.9f);

        RectTransform barRect = barObject.GetComponent<RectTransform>();
        barRect.anchorMin = new Vector2(0.5f, 0.12f);
        barRect.anchorMax = new Vector2(0.5f, 0.12f);
        barRect.sizeDelta = new Vector2(700, 18);
        barRect.anchoredPosition = Vector2.zero;

        float progress = 0f;

        while (!load.isDone)
        {
            progress = Mathf.MoveTowards(progress, 0.9f, Time.deltaTime * 0.35f);
            barRect.localScale = new Vector3(progress, 1f, 1f);

            if (load.progress >= 0.9f)
                break;

            yield return null;
        }

        while (progress < 1f)
        {
            progress += Time.deltaTime * 1.5f;
            progress = Mathf.Clamp01(progress);
            barRect.localScale = new Vector3(progress, 1f, 1f);
            yield return null;
        }

        yield return new WaitForSeconds(0.25f);

        load.allowSceneActivation = true;

        Destroy(canvasObject);
        Destroy(gameObject);
    }
}
