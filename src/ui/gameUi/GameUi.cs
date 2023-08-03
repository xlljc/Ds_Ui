using DsUi;

namespace UI.GameUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class GameUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: GameUi.Back
    /// </summary>
    public Back L_Back
    {
        get
        {
            if (_L_Back == null) _L_Back = new Back(this, GetNodeOrNull<Godot.Button>("Back"));
            return _L_Back;
        }
    }
    private Back _L_Back;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GameUi.HBoxContainer
    /// </summary>
    public HBoxContainer L_HBoxContainer
    {
        get
        {
            if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer(this, GetNodeOrNull<Godot.HBoxContainer>("HBoxContainer"));
            return _L_HBoxContainer;
        }
    }
    private HBoxContainer _L_HBoxContainer;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: GameUi.Coin
    /// </summary>
    public Coin L_Coin
    {
        get
        {
            if (_L_Coin == null) _L_Coin = new Coin(this, GetNodeOrNull<Godot.Label>("Coin"));
            return _L_Coin;
        }
    }
    private Coin _L_Coin;


    public GameUi() : base(nameof(GameUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: GameUi.Back
    /// </summary>
    public class Back : UiNode<GameUi, Godot.Button, Back>
    {
        public Back(GameUi uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Back Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: GameUi.HBoxContainer.Control.Package
    /// </summary>
    public class Package : UiNode<GameUi, Godot.Button, Package>
    {
        public Package(GameUi uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Package Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GameUi.HBoxContainer.Control.Label
    /// </summary>
    public class Label : UiNode<GameUi, Godot.Label, Label>
    {
        public Label(GameUi uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: GameUi.HBoxContainer.Control
    /// </summary>
    public class Control : UiNode<GameUi, Godot.Control, Control>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: GameUi.HBoxContainer.Package
        /// </summary>
        public Package L_Package
        {
            get
            {
                if (_L_Package == null) _L_Package = new Package(UiPanel, Instance.GetNodeOrNull<Godot.Button>("Package"));
                return _L_Package;
            }
        }
        private Package _L_Package;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: GameUi.HBoxContainer.Label
        /// </summary>
        public Label L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label(UiPanel, Instance.GetNodeOrNull<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label _L_Label;

        public Control(GameUi uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GameUi.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<GameUi, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: GameUi.Control
        /// </summary>
        public Control L_Control
        {
            get
            {
                if (_L_Control == null) _L_Control = new Control(UiPanel, Instance.GetNodeOrNull<Godot.Control>("Control"));
                return _L_Control;
            }
        }
        private Control _L_Control;

        public HBoxContainer(GameUi uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GameUi.Coin
    /// </summary>
    public class Coin : UiNode<GameUi, Godot.Label, Coin>
    {
        public Coin(GameUi uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Coin Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: GameUi.Back
    /// </summary>
    public Back S_Back => L_Back;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: GameUi.HBoxContainer.Control.Package
    /// </summary>
    public Package S_Package => L_HBoxContainer.L_Control.L_Package;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: GameUi.HBoxContainer.Control.Label
    /// </summary>
    public Label S_Label => L_HBoxContainer.L_Control.L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: GameUi.HBoxContainer.Control
    /// </summary>
    public Control S_Control => L_HBoxContainer.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GameUi.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: GameUi.Coin
    /// </summary>
    public Coin S_Coin => L_Coin;

}
