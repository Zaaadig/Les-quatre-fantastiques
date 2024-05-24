using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<ItemController> inventory;

    public static GameManager Instance;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);

        inventory.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("OUZF " + Camera.main);
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

    public bool HasAllItem()
    {
        return inventory.Count == 3;
    }
}
