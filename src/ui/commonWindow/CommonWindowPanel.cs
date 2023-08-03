using DsUi;
using Godot;

namespace UI.CommonWindow;

public partial class CommonWindowPanel : CommonWindow
{

    public override void OnCreateUi()
    {
        //绑定窗体关闭点击事件
        S_Window.Instance.CloseRequested += () =>
        {
            //销毁当前Ui
            Destroy();
        };
    }

    public override void OnDestroyUi()
    {
        
    }

    /// <summary>
    /// 窗体内打开的子Ui
    /// </summary>
    /// <param name="title">标题</param>
    /// <param name="uiName">Ui名称</param>
    public T OpenBody<T>(string title, string uiName) where T : UiBase
    {
        S_Window.Instance.Title = title;
        var body = S_Window.OpenNestedUi<T>(uiName);
        S_Window.Instance.Popup();
        return body;
    }
}
