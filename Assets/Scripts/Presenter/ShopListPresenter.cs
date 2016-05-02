using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopListPresenter : Presenter
{
    [SerializeField]
    private RectTransform shopListContents;

    [SerializeField]
    private ShopListItemPresenter shopListItem;

    public void SetShopItemModels(List<ShopItemModel> models)
    {
        shopListContents.sizeDelta = new Vector2(
            shopListContents.sizeDelta.x,
            ShopListItemPresenter.HEIGHT * models.Count);
        for (int i=0; i<models.Count; ++i) {
            ShopListItemPresenter tmp = Instantiate<ShopListItemPresenter>(shopListItem);
            tmp.SetParent(shopListContents);
            tmp.SetShopItemModel(i, models[i]);
        }
    }
}