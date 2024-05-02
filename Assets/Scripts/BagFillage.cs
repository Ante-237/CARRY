using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class BagFillage : MonoBehaviour
{
    [SerializeField] private Transform AnchorBagItems;
    [SerializeField] private GameObject CardViewPrefab;

    private int numberOfItems = 0;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("pickable"))
        {
            Sprite currentSprite = collision.gameObject.GetComponent<ItemRecord>().CoverImage;
            string currentName = collision.gameObject.GetComponent<ItemRecord>().Name;
            GameObject temp = Instantiate(CardViewPrefab, AnchorBagItems.transform);
            temp.GetComponentInChildren<Image>().sprite = currentSprite;
            temp.GetComponentInChildren<TextMeshProUGUI>().text = currentName;
            numberOfItems += 1;
            Destroy(collision.gameObject);
            Debug.LogWarning("Current Items in bucket" + numberOfItems);
        }
    }

   

}
