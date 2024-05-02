using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<ItemController> inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Pickable")
                {
                    ItemController item = hitInfo.collider.gameObject.GetComponent<ItemController>();
                    if (item)
                    {
                        inventory.Add(item);
                        Debug.Log(hitInfo.collider.gameObject.name + "Picked !");
                        item.transform.parent = transform;
                        item.gameObject.SetActive(false);
                    }
                }
            }
        }
    }

    public bool HasItem(ItemTypeEnum itemType)
    {
        ItemController foundItem = inventory.Find(item => item.ItemType == itemType);

        if (foundItem)
            return true;

        return false;
    }
}
