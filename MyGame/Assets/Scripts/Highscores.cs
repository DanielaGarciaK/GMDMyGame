using UnityEngine;
using System.Collections;

public class Highscores : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    private void Awake()
    {
        entryContainer = transform.Find("hsEntryContainer");
        entryTemplate = entryContainer.Find("hsline");

        entryTemplate.gameObject.SetActive(false);


        float templateHeight = 20f;
        for (int i=0; i<5; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);
        }
    }
}
