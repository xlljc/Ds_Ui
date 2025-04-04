namespace UI.Menu;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Menu : UiBase
{
    /// <summary>
    /// 节点路径: Menu.VBoxContainer
    /// </summary>
    public VBoxContainer L_VBoxContainer
    {
        get
        {
            if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer((MenuPanel)this, GetNode<Godot.VBoxContainer>("VBoxContainer"));
            return _L_VBoxContainer;
        }
    }
    private VBoxContainer _L_VBoxContainer;


    public Menu() : base(nameof(Menu))
    {
    }

    public sealed override void OnInitNestedUi()
    {
        _ = L_VBoxContainer.L_Control.L_VBoxContainer.L_Custom;

    }

    /// <summary>
    /// 路径: Menu.VBoxContainer.Label
    /// </summary>
    public class Label : UiNode<MenuPanel, Godot.Label, Label>
    {
        public Label(MenuPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Label Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Menu.VBoxContainer.Control.VBoxContainer.Start
    /// </summary>
    public class Start : UiNode<MenuPanel, Godot.Button, Start>
    {
        public Start(MenuPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Start Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Menu.VBoxContainer.Control.VBoxContainer.Setting
    /// </summary>
    public class Setting : UiNode<MenuPanel, Godot.Button, Setting>
    {
        public Setting(MenuPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Setting Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Menu.VBoxContainer.Control.VBoxContainer.Custom
    /// </summary>
    public class Custom : UiNode<MenuPanel, UI.Menu.CustomButton, Custom>
    {
        public Custom(MenuPanel uiPanel, UI.Menu.CustomButton node) : base(uiPanel, node) {  }
        public override Custom Clone() => new (UiPanel, (UI.Menu.CustomButton)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Menu.VBoxContainer.Control.VBoxContainer.Exit
    /// </summary>
    public class Exit : UiNode<MenuPanel, Godot.Button, Exit>
    {
        public Exit(MenuPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Exit Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Menu.VBoxContainer.Control.VBoxContainer
    /// </summary>
    public class VBoxContainer_1 : UiNode<MenuPanel, Godot.VBoxContainer, VBoxContainer_1>
    {
        /// <summary>
        /// 节点路径: Menu.VBoxContainer.Control.Start
        /// </summary>
        public Start L_Start
        {
            get
            {
                if (_L_Start == null) _L_Start = new Start(UiPanel, Instance.GetNode<Godot.Button>("Start"));
                return _L_Start;
            }
        }
        private Start _L_Start;

        /// <summary>
        /// 节点路径: Menu.VBoxContainer.Control.Setting
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
        /// 节点路径: Menu.VBoxContainer.Control.Custom
        /// </summary>
        public Custom L_Custom
        {
            get
            {
                if (_L_Custom == null) _L_Custom = new Custom(UiPanel, Instance.GetNode<UI.Menu.CustomButton>("Custom"));
                return _L_Custom;
            }
        }
        private Custom _L_Custom;

        /// <summary>
        /// 节点路径: Menu.VBoxContainer.Control.Exit
        /// </summary>
        public Exit L_Exit
        {
            get
            {
                if (_L_Exit == null) _L_Exit = new Exit(UiPanel, Instance.GetNode<Godot.Button>("Exit"));
                return _L_Exit;
            }
        }
        private Exit _L_Exit;

        public VBoxContainer_1(MenuPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer_1 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Menu.VBoxContainer.Control
    /// </summary>
    public class Control : UiNode<MenuPanel, Godot.Control, Control>
    {
        /// <summary>
        /// 节点路径: Menu.VBoxContainer.VBoxContainer
        /// </summary>
        public VBoxContainer_1 L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer_1(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer_1 _L_VBoxContainer;

        public Control(MenuPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 路径: Menu.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<MenuPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 节点路径: Menu.Label
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

        /// <summary>
        /// 节点路径: Menu.Control
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

        public VBoxContainer(MenuPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Menu.VBoxContainer.Label
    /// </summary>
    public Label S_Label => L_VBoxContainer.L_Label;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Menu.VBoxContainer.Control.VBoxContainer.Start
    /// </summary>
    public Start S_Start => L_VBoxContainer.L_Control.L_VBoxContainer.L_Start;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Menu.VBoxContainer.Control.VBoxContainer.Setting
    /// </summary>
    public Setting S_Setting => L_VBoxContainer.L_Control.L_VBoxContainer.L_Setting;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Menu.VBoxContainer.Control.VBoxContainer.Custom
    /// </summary>
    public Custom S_Custom => L_VBoxContainer.L_Control.L_VBoxContainer.L_Custom;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Menu.VBoxContainer.Control.VBoxContainer.Exit
    /// </summary>
    public Exit S_Exit => L_VBoxContainer.L_Control.L_VBoxContainer.L_Exit;

    /// <summary>
    /// 场景中唯一名称的节点, 节点路径: Menu.VBoxContainer.Control
    /// </summary>
    public Control S_Control => L_VBoxContainer.L_Control;

}
