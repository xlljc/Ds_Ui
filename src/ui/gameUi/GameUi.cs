namespace UI.GameUi;

using DsUi;

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
            if (_L_Back == null) _L_Back = new Back((GameUiPanel)this, GetNode<Godot.Button>("Back"));
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
            if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer((GameUiPanel)this, GetNode<Godot.HBoxContainer>("HBoxContainer"));
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
            if (_L_Coin == null) _L_Coin = new Coin((GameUiPanel)this, GetNode<Godot.Label>("Coin"));
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
    public class Back : UiNode<GameUiPanel, Godot.Button, Back>
    {
        public Back(GameUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Back Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: GameUi.HBoxContainer.Control.Package
    /// </summary>
    public class Package : UiNode<GameUiPanel, Godot.Button, Package>
    {
        public Package(GameUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Package Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GameUi.HBoxContainer.Control.Label
    /// </summary>
    public class Label : UiNode<GameUiPanel, Godot.Label, Label>
    {
        public Label(GameUiPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: GameUi.HBoxContainer.Control
    /// </summary>
    public class Control : UiNode<GameUiPanel, Godot.Control, Control>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: GameUi.HBoxContainer.Package
        /// </summary>
        public Package L_Package
        {
            get
            {
                if (_L_Package == null) _L_Package = new Package(UiPanel, Instance.GetNode<Godot.Button>("Package"));
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
                if (_L_Label == null) _L_Label = new Label(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label _L_Label;

        public Control(GameUiPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: GameUi.HBoxContainer.Control2.Setting
    /// </summary>
    public class Setting : UiNode<GameUiPanel, Godot.Button, Setting>
    {
        public Setting(GameUiPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Setting Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GameUi.HBoxContainer.Control2.Label
    /// </summary>
    public class Label_1 : UiNode<GameUiPanel, Godot.Label, Label_1>
    {
        public Label_1(GameUiPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label_1 Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: GameUi.HBoxContainer.Control2
    /// </summary>
    public class Control2 : UiNode<GameUiPanel, Godot.Control, Control2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: GameUi.HBoxContainer.Setting
        /// </summary>
        public Setting L_Setting
        {
            get
            {
                if (_L_Setting == null) _L_Setting = new Setting(UiPanel, Instance.GetNode<Godot.Button>("Setting"));
                return _L_Setting;
            }
        }
        private Setting _L_Setting;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: GameUi.HBoxContainer.Label
        /// </summary>
        public Label_1 L_Label
        {
            get
            {
                if (_L_Label == null) _L_Label = new Label_1(UiPanel, Instance.GetNode<Godot.Label>("Label"));
                return _L_Label;
            }
        }
        private Label_1 _L_Label;

        public Control2(GameUiPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control2 Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: GameUi.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<GameUiPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: GameUi.Control
        /// </summary>
        public Control L_Control
        {
            get
            {
                if (_L_Control == null) _L_Control = new Control(UiPanel, Instance.GetNode<Godot.Control>("Control"));
                return _L_Control;
            }
        }
        private Control _L_Control;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: GameUi.Control2
        /// </summary>
        public Control2 L_Control2
        {
            get
            {
                if (_L_Control2 == null) _L_Control2 = new Control2(UiPanel, Instance.GetNode<Godot.Control>("Control2"));
                return _L_Control2;
            }
        }
        private Control2 _L_Control2;

        public HBoxContainer(GameUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: GameUi.Coin
    /// </summary>
    public class Coin : UiNode<GameUiPanel, Godot.Label, Coin>
    {
        public Coin(GameUiPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
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
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: GameUi.HBoxContainer.Control
    /// </summary>
    public Control S_Control => L_HBoxContainer.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: GameUi.HBoxContainer.Control2.Setting
    /// </summary>
    public Setting S_Setting => L_HBoxContainer.L_Control2.L_Setting;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: GameUi.HBoxContainer.Control2
    /// </summary>
    public Control2 S_Control2 => L_HBoxContainer.L_Control2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: GameUi.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: GameUi.Coin
    /// </summary>
    public Coin S_Coin => L_Coin;

}
