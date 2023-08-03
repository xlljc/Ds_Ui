using DsUi;

namespace UI.Package;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Package : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: Package.ScrollContainer
    /// </summary>
    public ScrollContainer L_ScrollContainer
    {
        get
        {
            if (_L_ScrollContainer == null) _L_ScrollContainer = new ScrollContainer(this, GetNodeOrNull<Godot.ScrollContainer>("ScrollContainer"));
            return _L_ScrollContainer;
        }
    }
    private ScrollContainer _L_ScrollContainer;


    public Package() : base(nameof(Package))
    {
    }

    public sealed override void OnInitNestedUi()
    {
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: Package.ScrollContainer.Item.ItemName
    /// </summary>
    public class ItemName : UiNode<Package, Godot.Label, ItemName>
    {
        public ItemName(Package uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override ItemName Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: Package.ScrollContainer.Item.Mask.UseButton
    /// </summary>
    public class UseButton : UiNode<Package, Godot.Button, UseButton>
    {
        public UseButton(Package uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override UseButton Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ColorRect"/>, 路径: Package.ScrollContainer.Item.Mask
    /// </summary>
    public class Mask : UiNode<Package, Godot.ColorRect, Mask>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: Package.ScrollContainer.Item.UseButton
        /// </summary>
        public UseButton L_UseButton
        {
            get
            {
                if (_L_UseButton == null) _L_UseButton = new UseButton(UiPanel, Instance.GetNodeOrNull<Godot.Button>("UseButton"));
                return _L_UseButton;
            }
        }
        private UseButton _L_UseButton;

        public Mask(Package uiPanel, Godot.ColorRect node) : base(uiPanel, node) {  }
        public override Mask Clone() => new (UiPanel, (Godot.ColorRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureButton"/>, 路径: Package.ScrollContainer.Item
    /// </summary>
    public class Item : UiNode<Package, Godot.TextureButton, Item>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: Package.ScrollContainer.ItemName
        /// </summary>
        public ItemName L_ItemName
        {
            get
            {
                if (_L_ItemName == null) _L_ItemName = new ItemName(UiPanel, Instance.GetNodeOrNull<Godot.Label>("ItemName"));
                return _L_ItemName;
            }
        }
        private ItemName _L_ItemName;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Package.ScrollContainer.Mask
        /// </summary>
        public Mask L_Mask
        {
            get
            {
                if (_L_Mask == null) _L_Mask = new Mask(UiPanel, Instance.GetNodeOrNull<Godot.ColorRect>("Mask"));
                return _L_Mask;
            }
        }
        private Mask _L_Mask;

        public Item(Package uiPanel, Godot.TextureButton node) : base(uiPanel, node) {  }
        public override Item Clone() => new (UiPanel, (Godot.TextureButton)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.ScrollContainer"/>, 路径: Package.ScrollContainer
    /// </summary>
    public class ScrollContainer : UiNode<Package, Godot.ScrollContainer, ScrollContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: Package.Item
        /// </summary>
        public Item L_Item
        {
            get
            {
                if (_L_Item == null) _L_Item = new Item(UiPanel, Instance.GetNodeOrNull<Godot.TextureButton>("Item"));
                return _L_Item;
            }
        }
        private Item _L_Item;

        public ScrollContainer(Package uiPanel, Godot.ScrollContainer node) : base(uiPanel, node) {  }
        public override ScrollContainer Clone() => new (UiPanel, (Godot.ScrollContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: Package.ScrollContainer.Item.ItemName
    /// </summary>
    public ItemName S_ItemName => L_ScrollContainer.L_Item.L_ItemName;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: Package.ScrollContainer.Item.Mask.UseButton
    /// </summary>
    public UseButton S_UseButton => L_ScrollContainer.L_Item.L_Mask.L_UseButton;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ColorRect"/>, 节点路径: Package.ScrollContainer.Item.Mask
    /// </summary>
    public Mask S_Mask => L_ScrollContainer.L_Item.L_Mask;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureButton"/>, 节点路径: Package.ScrollContainer.Item
    /// </summary>
    public Item S_Item => L_ScrollContainer.L_Item;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.ScrollContainer"/>, 节点路径: Package.ScrollContainer
    /// </summary>
    public ScrollContainer S_ScrollContainer => L_ScrollContainer;

}