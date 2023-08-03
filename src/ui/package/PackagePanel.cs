using System.Collections.Generic;
using DsUi;
using Godot;

namespace UI.Package;

public partial class PackagePanel : Package
{
    /// <summary>
    /// 用于传入背包Cell的数据
    /// </summary>
    public class ItemCellData
    {
        /// <summary>
        /// 奖励金币
        /// </summary>
        public int Coin;
        /// <summary>
        /// 道具名称
        /// </summary>
        public string Name;

        public ItemCellData(int coin, string name)
        {
            Coin = coin;
            Name = name;
        }
    }

    private UiGrid<Item, ItemCellData> _grid;
    
    public override void OnCreateUi()
    {
        //------------ 测试数据 -----------------
        var list = new List<ItemCellData>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(new ItemCellData(i + 1, "增加金币: " + (i + 1)));
        }
        
        //-------------------------------------
        
        //创建网格组件, 第一个参数为 Ui 模板节点, 第二个参数为处理 Cell 逻辑的类
        //一旦设置模板节点, 原模板对象将被隐藏
        _grid = new UiGrid<Item, ItemCellData>(S_Item, typeof(PackageItemCell));
        //设置每个Cell之间的间距
        _grid.SetCellOffset(new Vector2I(10, 10));
        //根据父级宽度自动计算列数
        _grid.SetAutoColumns(true);
        //_grid.SetColumns(10); //也可以设置固定列数
        //自动横向填充父级
        _grid.SetHorizontalExpand(true);
        //初始化数据
        _grid.SetDataList(list.ToArray());
    }

    public override void OnDestroyUi()
    {
        //销毁Ui时记得销毁Grid组件
        _grid.Destroy();
    }

}
