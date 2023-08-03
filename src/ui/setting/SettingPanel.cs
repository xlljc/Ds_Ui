using Godot;
using DsUi;

namespace UI.Setting;

public partial class SettingPanel : Setting
{

    public override void OnCreateUi()
    {
        S_Back.Instance.Pressed += OnBack;
    }

    public override void OnDestroyUi()
    {

    }

    //返回上一级Ui
    private void OnBack()
    {
        Destroy();
        if (PrevUi != null)
        {
            PrevUi.ShowUi();
        }
    }

}
