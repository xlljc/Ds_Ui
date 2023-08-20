namespace UI.CommonWindow;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class CommonWindow : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Window"/>, 节点路径: CommonWindow.Window
    /// </summary>
    public Window L_Window
    {
        get
        {
            if (_L_Window == null) _L_Window = new Window((CommonWindowPanel)this, GetNode<Godot.Window>("Window"));
            return _L_Window;
        }
    }
    private Window _L_Window;


    public CommonWindow() : base(nameof(CommonWindow))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.Window"/>, 路径: CommonWindow.Window
    /// </summary>
    public class Window : UiNode<CommonWindowPanel, Godot.Window, Window>
    {
        public Window(CommonWindowPanel uiPanel, Godot.Window node) : base(uiPanel, node) {  }
        public override Window Clone() => new (UiPanel, (Godot.Window)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Window"/>, 节点路径: CommonWindow.Window
    /// </summary>
    public Window S_Window => L_Window;

}
