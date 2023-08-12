using DsUi;

namespace UI.Package;

public class PackageItemCell : UiCell<Package.Item, PackagePanel.ItemCellData>
{
    //cell初始化时调用
    public override void OnInit()
    {
        // CellNode 表示当前从模板对象克隆出来的新对象
        //隐藏选中按钮
        CellNode.L_Mask.Instance.Visible = false;
        //使用按钮
        CellNode.L_Mask.L_UseButton.Instance.Pressed += OnUse;
    }

    //当cell被赋予数据时调用
    public override void OnSetData(PackagePanel.ItemCellData data)
    {
        CellNode.L_ItemName.Instance.Text = data.Name;
    }

    public override void OnClick()
    {
        //选中cell, 并会触发选中的函数
        Grid.SelectIndex = Index;
    }

    //使用按钮
    private void OnUse()
    {
        //移除当前cell
        Grid.RemoveByIndex(Index);
        //调用主菜单加钱
        var gameUis = UiManager.Get_GameUi_Instance();
        if (gameUis.Length > 0)
        {
            gameUis[0].AddCoin(Data.Coin);
        }
    }

    //当选中当前cell时调用
    public override void OnSelect()
    {
        //显示使用按钮
        CellNode.L_Mask.Instance.Visible = true;
    }
    
    //当取消选中当前cell时调用
    public override void OnUnSelect()
    {
        //隐藏使用按钮
        CellNode.L_Mask.Instance.Visible = false;
    }
}