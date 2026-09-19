using UnityEngine;

public class MergeItem : MonoBehaviour
{
    public string itemType = "Sock";
    public int level = 1;

    private bool isMerging = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isMerging) return;

        MergeItem otherItem = other.GetComponent<MergeItem>();

        if (otherItem != null &&
            otherItem.itemType == itemType &&
            otherItem.level == level &&
            !otherItem.isMerging)
        {
            isMerging = true;
            otherItem.isMerging = true;

            Debug.Log("Merging two socks!");

            Destroy(otherItem.gameObject);
            Destroy(gameObject);
        }
    }
}