using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootPresenter : Presenter
{
    [SerializeField]
    private ShopListPresenter shopList;

    [SerializeField]
    private List<ShopItemModel> models;

    void Start()
    {
        shopList.SetShopItemModels(models);
    }
}
