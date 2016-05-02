using System;
using UnityEngine;
using UnityEngine.UI;

public class ShopListItemPresenter : Presenter
{
    public static float HEIGHT = 110.0f;

    [SerializeField]
    private Text nameText;

    [SerializeField]
    private Text priceText;

    public void SetShopItemModel(int index, ShopItemModel model)
    {
        name = string.Format("ShopListItem_{0}", index);

        nameText.text = model.name;
        priceText.text = string.Format("{0}円", model.price);
    }

    public void SetParent(Transform parent)
    {
        transform.parent = parent;
        transform.localScale = Vector3.one;
    }

    public void OnClick()
    {
        //ボタン押下処理
    }
}